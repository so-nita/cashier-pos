using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interface.ISubCategory;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.SubCategory;

namespace CashierPOS.WebApi.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IRepository<SubCategory> _repo;
        private readonly IMapper _mapper;
        private readonly IRepository<Category> _repoCate;

        public SubCategoryService(IRepository<SubCategory> repository,IMapper mapper,IRepository<Category> repoCategory)
        {
            _repo = repository;
            _mapper = mapper;
            _repoCate = repoCategory;
        }
        public Response<string> Create(SubCategoryCreateReq req)
        {
            try
            {
                var dataErrors = DataValidation<SubCategoryCreateReq>.ValidateDynamicTypes(req);
                if (dataErrors.Count > 0)
                {
                    return Response<string>.Fail(data: dataErrors.First().ToString());
                }
                var categoryFound = _repoCate.GetById(req.Main_Category_Id);
                if(categoryFound == null)
                {
                    return Response<string>.Conflict($"Main category Id '{req.Main_Category_Id}' not found.");
                }

                var checkExistName = _repo.GetQueryable().Any(e => e.Name == req.Name && e.Is_Deleted.Equals(false));
                if (checkExistName)
                {
                    return Response<string>.Conflict("Name is existing.Plase try another name.");
                }

                var data = new SubCategory()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = req.Name,
                    Main_Category_Id = req.Main_Category_Id,
                    Image = req.Image,
                    Description = req.Description,
                    Create_At = DateTime.Now,
                    Is_Deleted = false,
                };
                
                _repo.Add(data);

                return _repo.SaveChanges()>0 ? Response<string>.Success("Create Successfully") : Response<string>.Fail("Fail to create");
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }
        private Response<List<SubCategoryResponse?>> GetAll()
        {
            try
            {
                var data = _repo.GetQueryable()
                    .Include(e=>e.Category)
                    .Include(e=>e.Category.Menu.Division)
                    .Select(e=>new SubCategoryResponse()
                    {
                        Id = e.Id,
                        Name = e.Name.ToUpper(),
                        Main_Category_Id = e.Main_Category_Id,
                        Main_Category_Name = e.Category.Name,
                        Status = e.Status,
                        Image = e.Image,
                        Create_At = DateTime.Now,
                        Is_Deleted = e.Is_Deleted
                    }).ToList();
                return Response<List<SubCategoryResponse?>>.Success(data!);
            }
            catch (Exception ex)
            {
                return Response<List<SubCategoryResponse?>>.Fail();
            }
        }
        public Response<SubCategoryResponse?> Read(Key key)
        {
            try
            {
                var data = GetAll().Result!.FirstOrDefault(e => e.Id == key.Id && e.Is_Deleted == false);
                if(data == null)
                    return Response<SubCategoryResponse?>.NotFound();

                return Response<SubCategoryResponse>.Success(data)!;
            }
            catch (Exception ex)
            {
                return Response<SubCategoryResponse>.Fail()!;
            }
        }

        public Response<List<SubCategoryResponse>>? ReadAll()
        {
            try
            {
                var data = GetAll().Result!.Where(e => e.Is_Deleted == false).ToList();

                return Response<List<SubCategoryResponse>>.Success(data!, data.Count());
            }
            catch (Exception ex)
            {
                return Response<List<SubCategoryResponse>>.Fail();
            }
        }

        public Response<string> Update(SubCategoryUpdateReq req)
        {
            try
            {
                var subCateFound = _repo.GetQueryable().FirstOrDefault(e=>e.Id==req.Id && e.Is_Deleted.Equals(false));
                if(subCateFound == null)
                    return Response<string>.NotFound("SubCategory not found.");
                
                var data = _mapper.Map(req, subCateFound);
                
                _repo.Update(data);
                
                return _repo.SaveChanges()>0 ? Response<string>.Success("Update Successfully") : Response<string>.Fail("Fail to Update.");
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }
        public Response<string> Delete(Key key)
        {
            try
            {
                var found = _repo.GetById(key.Id);
                if (found == null) return Response<string>.NotFound("Sub Category not found.");

                found.Is_Deleted = true;
                _repo.Update(found);

                return _repo.SaveChanges() > 0 ? Response<string>.Success("Deleted Successfully.")
                                               : Response<string>.Fail("Failed to delete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail(ex.Message);
            }
        }

        
    }
}
