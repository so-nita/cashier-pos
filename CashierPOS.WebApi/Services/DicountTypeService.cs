using AutoMapper;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.DiscountType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.IdentityModel.Tokens;

namespace CashierPOS.WebApi.Services
{
    public class DicountTypeService : IDicountTypeService
    {
        private readonly IRepository<DiscountType> _repo;
        private readonly IUserService _repoUser;
        private readonly IApprovalStrategy _approveStrategy;
        private readonly IMapper _mapper;

        public DicountTypeService(IRepository<DiscountType> repo, IApprovalStrategy approval, IUserService repoUser, IMapper mapper)
        {
            _repo = repo;
            _approveStrategy = approval;
            _repoUser = repoUser;
            _mapper = mapper;
        }

        public Response<string> Create(DicountTypeCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<DicountTypeCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors != null)
                {
                    return Response<string>.Fail(dataErrors.First().ToString());
                }
                var userRequest = new Key()
                {
                    Id = request.UserId,
                };
                var userResponse = _repoUser.Read(userRequest);
                if (userResponse.Result == null)
                {
                    return Response<string>.NotFound("User not found.");
                }

                var newDiscount = new DiscountType(); 
                if (_approveStrategy.CanCreateDiscount(userResponse.Result))
                {
                    newDiscount = new DiscountType()
                    {
                        Id = Guid.NewGuid().ToString(),
                        CreateAt = DateTime.Now,
                        //EndAt = request.,
                    };
                }
                return Response<string>.Success();
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Delete(Key key)
        {
            throw new Exception();
        }

        public Response<DicountTypeResponse?> Read(Key request)
        {
            try
            {
                if (request.Id.IsNullOrEmpty())
                {
                    return Response<DicountTypeResponse?>.Fail("Field Id is required.");
                }
                var data = _repo.GetById(request.Id!);
                if(data == null)
                {
                    return Response<DicountTypeResponse?>.NotFound("Discount not found.");
                }
                var result = new DicountTypeResponse()
                {
                    Id = data.Id,
                    Name = data.Name,
                    StartAt = data.StartAt, 
                    EndAt = data.EndAt,
                    DiscountPercent = data.DiscountPercent,
                };

                return Response<DicountTypeResponse?>.Success(result,1,"Successfully");
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<DicountTypeResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Where(e=>e.IsDeleted==false).Select(e => new DicountTypeResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    StartAt = e.StartAt,
                    EndAt = e.EndAt,
                    DiscountPercent = e.DiscountPercent,
                }).ToList();
                return Response<List<DicountTypeResponse>>.Success(data,data.Count,"Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Update(DicountTypeUpdateReq request)
        {
            try
            {
                var discount = _repo.GetById(request.DiscountId);
                if (discount==null)
                {
                    return Response<string>.NotFound("Discount not found.");
                }

                var data = _mapper.Map<DiscountType>(request);

                _repo.Update(data);

                int result = _repo.SaveChanges();

                return result>0 ? Response<string>.Success(null,0,"Successfully") : Response<string>.Fail("Failed.");
            }catch (Exception ex)
            {
                _repo.Rollback();
                throw ex.InnerException!;
            }
        }
    }
}
