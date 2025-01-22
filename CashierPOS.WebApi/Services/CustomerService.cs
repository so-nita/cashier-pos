using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Customer;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;
using System.Security.AccessControl;

namespace CashierPOS.WebApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _repo;
        private readonly IRepository<CustomerType> _repoCustomerType;

        public CustomerService(IRepository<Customer> repo, IRepository<CustomerType> repoCustomerType)
        {
            _repo = repo;
            _repoCustomerType = repoCustomerType;
        }

        private string _prefix { get; set; } = "K";
        public Response<string> Create(CustomerCreateReq request)
        {
            try
            {
                var dataErros = DataValidation<CustomerCreateReq>.ValidateDynamicTypes(request);
                if(dataErros.Count > 0 )
                {
                    return Response<string>.Fail(dataErros.First());
                }

                //var customerContact = request.Contact.Replace(" ", "");
                var customers = _repo.GetAll().ToList();
                var existContact = customers.FirstOrDefault(e => e.Contact == /*customerContact*/ request.Contact);
                if (existContact != null)
                {
                    return Response<string>.Fail("This contact has already been registered");
                }
                var lastCode = customers.OrderByDescending(e=>e.Code).FirstOrDefault()?.Code;
                var newCode = GenerateCode(lastCode!);

                var customerTypes = _repoCustomerType.GetAll().FirstOrDefault(e=>e.Name.Contains(request.CustomerTypeCode.ToString()));

                var newCustomer = new Customer()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = request.Name,
                    Code = newCode,
                    Contact = /*customerContact*/ request.Contact,
                    Nationality = request.Nationality.ToString(),
                    Gender = request.Gender.ToString(),
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    Status = Status.Enable,
                    CustomerTypeCode = customerTypes?.Code,
                };
                _repo.Add(newCustomer);

                int result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success("Created Successfully") : Response<string>.Fail("Failed to create new customer");
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }

        private string GenerateCode(string code)
        {
            if (int.TryParse(code?.Substring(1), out int lastNumber))
            {
                lastNumber++; 
                string formattedInvoiceNumber = lastNumber.ToString("D8");
                return $"{_prefix}{formattedInvoiceNumber}";
            }
            return $"{_prefix}00000001"; // Default starting value
        }

        public Response<string> Delete(CustomerDeleteReq key)
        {
            try
            {
                int result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<CustomerResponse?> Read(Key key)
        {
            try
            {
                var data = _repo.GetAll().Where(e=>e.Id == key.Id || e.Code == key.Code).Select(e => new CustomerResponse()
                {
                    CustomerId = e.Id,
                    CustomerCode = e.Code,
                    CustomerName = e.Name,  
                    Contact = e.Contact,
                    EarningPoint = e.EarningPoint ?? 0,
                    EarningAmount = e.EarningAmount ?? 0,
                    Email = e.Email,
                    Gender = e.Gender?.ToString(), 
                    Nationaltity = e.Nationality?.ToString(),
                }).OrderBy(e=>e.CustomerCode);
                return Response<CustomerResponse?>.Success(data.First(), data.Count(), "Successfully");
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<CustomerResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Select(e => new CustomerResponse()
                {
                    CustomerCode = e.Code,
                    CustomerName = e.Name,
                    Contact = e.Contact,
                    EarningPoint = e.EarningPoint ?? 0,
                    EarningAmount = e.EarningAmount ?? 0,
                    Email = e.Email,
                    Gender = e.Gender ,
                    Nationaltity = e.Nationality ,    
                }).OrderBy(e => e.CustomerCode).ToList();
                return Response<List<CustomerResponse>>.Success(data, data.Count(), "Successfully");
            }
            catch (Exception ex)
            {
                return Response<List<CustomerResponse>>.Fail(ex.Message);
            }
        }

        public Response<string> Update(CustomerUpdateReq req)
        {
            try
            {
                int result = _repo.SaveChanges();
                return result > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }
    }
}
