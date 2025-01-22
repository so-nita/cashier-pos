using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Brand;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.Services
{
    public class BrandService : IProductBrand
    {
        private readonly IRepository<Brand> _repo;
        private readonly IRepository<Product> _repoProduct;

        public BrandService(IRepository<Brand> repo, IRepository<Product> repoProduct)
        {
            _repo = repo;
            _repoProduct = repoProduct;
        }

        public Response<string> Create(BrandCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<BrandCreateReq>.ValidateDynamicTypes(request);
                if(dataErrors.Count > 0)
                {
                    return Response<string>.Fail(dataErrors.First());
                }

                var brands = _repo.GetAll().FirstOrDefault(e => e.Name.ToLower() == request.Name.ToLower());

                if(brands != null)
                {
                    return Response<string>.Fail("Name is existing. Please try another name");
                }

                var brand = new Brand()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = request.Name,
                    Status = Status.Enable ,
                    CreatedAt = DateTime.Now,
                    Description = request.Description,
                    IsDeleted = false,
                };

                _repo.Add(brand);
                int result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success("") : Response<string>.Fail("");
            }catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
                throw ex.InnerException;
            }
        }

        public Response<string> Delete(BrandDeleteReq key)
        {
            try
            {
                var brand = _repo.GetById(key.Id);
                if(brand == null)
                {
                    return Response<string>.Fail("Brand not found");
                }

                brand.Status = Status.Disable;
                brand.IsDeleted = false;

                _repo.Update(brand);
                int result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success("") : Response<string>.Fail("");
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
                throw ex.InnerException;
            }
        }

        public Response<BrandResponse?> Read(Key key)
        {
            try
            {
                var data = _repo.GetAll().Where(e => e.Id == key.Id || e.Code.ToString() == key.Code
                            && e.IsDeleted == false)
                           .Select(e=> new BrandResponse()
                           {
                               Id = e.Id,   
                               Code = e.Code,
                               Name = e.Name,
                               Description = e.Description,
                           });
                if (data == null)
                {
                    return Response<BrandResponse?>.Fail("Brand not found");
                }
                return Response<BrandResponse?>.Success(data.First(), data.Count(), "Successfully");

            }catch (Exception ex)
            {
                return Response<BrandResponse?>.Fail(ex.Message);
                throw ex.InnerException;
            }
        }

        public Response<List<BrandResponse>>? ReadAll()
        {
            try
            {
                /*var data = _repo.GetAll().Where(e => e.IsDeleted == false)
                           .Select(e => new BrandResponse()
                           {
                               Id = e.Id,
                               Code = e.Code,
                               Name = e.Name,
                               Description = e.Description,
                           }).ToList();*/
                var data = _repoProduct.GetAll().Select(e => new BrandResponse()
                {
                    Id = null!,
                    Name = e.Brand!,
                }).DistinctBy(e=>e.Name).ToList();
                return Response<List<BrandResponse>>.Success(data, data.Count(), "Successfully");
            }
            catch (Exception ex)
            {
                return Response<List<BrandResponse>>.Fail(ex.Message);
                throw ex.InnerException;
            }
        }

        public Response<string> Update(BrandUpdateReq request)
        {
            try
            {
                var brand = _repo.GetById(request.Id);
                if(brand == null)
                {
                    return Response<string>.Fail("Brand not found");
                }

                brand.Name = request.Name ?? brand.Name;
                brand.Description = request.Description ?? brand.Description;

                _repo.Update(brand);
                int result = _repo.SaveChanges();

                return result > 0 ? Response<string>.Success("",0,"Update Successfully") : Response<string>.Fail("Failed to update");
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
                throw ex.InnerException;
            }
        }
    }
}
