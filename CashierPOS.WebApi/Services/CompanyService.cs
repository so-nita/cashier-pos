using AutoMapper;
using CashierPOS.Model.Models;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.WebApi.Models.RequestModel.Company;
using CashierPOS.Model.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace CashierPOS.WebApi.Services;
public class CompanyService : ICompanyService
{
    private readonly IRepository<Company> _repo;
    private readonly IMapper _mapper;

    public CompanyService(IRepository<Company> repository,IMapper mapper)
    {
        _repo = repository;
        _mapper = mapper;
    }

    private Response<IEnumerable<CompanyResponse>>? GetAll()
    {
        try
        {
            var companies = _repo.GetQueryable()?.Include(e=>e.SystemType).Select(e => new CompanyResponse()
            {
                Id = e.Id,
                Name = e.Name,
                System_Id = e.System_Id,
                System_Name = e.SystemType.Name,
                Email = e.Email,
                Contact = e.Contact,
                Address = e.Address,
                Image = e.Image,
                Website = e.Website,
                Create_At = e.Create_At,
                Status = e.Status.ToString(),
                Is_Deleted = e.Is_Deleted
            }).ToList();
            return Response<IEnumerable<CompanyResponse>>.Success(companies);               
        }catch (Exception ex)
        {
            return Response<IEnumerable<CompanyResponse>>.Fail(ex.Message);
        }
    }

    public Response<string> Create(CompanyCreateReq req)
    {
        try
        {
            var dataErrors = DataValidation<CompanyCreateReq>.ValidateDynamicTypes(req);
            if (dataErrors.Count > 0)
            {
                return Response<string>.Fail(data: dataErrors.First().ToString());
            }

            var company = new Company()
            {
                Id = Guid.NewGuid().ToString(),
                Name = req.Name,
                System_Id = req.System_Id,
                Email = req.Email,  
                Contact = req.Contact,  
                Address = req.Address,
                Image = req.Image,
                Website = req.Website,  
                Create_At = DateTime.Now,
                Status = req.Status,
                Is_Deleted = false 
            };

            _repo.Add(company);
            return _repo.SaveChanges() > 0 ? Response<string>.Success("Create Successfully.")
                                           : Response<string>.Fail("Fail to create.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Response<string>.Fail(ex.Message);
        }
    }

    public Response<CompanyResponse?> Read(Key key)
    {
        try
        {
            var data = GetAll().Result!.FirstOrDefault(e =>e.Id == key.Id && e.Is_Deleted.Equals(false)) ;
            return Response<CompanyResponse?>.Success(data);
        }catch(Exception ex)
        {
            return Response<CompanyResponse?>.Fail();
        }
    }

    public Response<List<CompanyResponse>>? ReadAll()
    {
        try
        {
            var data = GetAll().Result!.Where(e => e.Is_Deleted.Equals(false)).ToList();
            return Response<List<CompanyResponse>>.Success(data,data.Count());
        }
        catch (Exception ex)
        {
            return Response<List<CompanyResponse>>.Fail();
        }
    }

    public Response<string> Update(CompanyUpdateReq req)
    {
        try
        {
            var companyFound = _repo.GetQueryable().FirstOrDefault(e => e.Id.Equals(req.Id) && e.Is_Deleted.Equals(false));
            if (companyFound == null)
            {
                return Response<string>.NotFound($"Company not found.");
            }
            var data = _mapper.Map(req, companyFound);

            _repo.Update(data);

            return _repo.SaveChanges()>0 ? Response<string>.Success($"Update Successfully.") : Response<string>.Fail($"Fail to Update.");
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
            if (found == null) return Response<string>.NotFound("Compnay not found.");

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