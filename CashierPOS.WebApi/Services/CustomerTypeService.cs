using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.CustomerType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;
 

namespace CashierPOS.WebApi.Services
{
    public class CustomerTypeService : ICustomerTypeService
    {
        private readonly IRepository<CustomerType> _repo;
        public CustomerTypeService(IRepository<CustomerType> repo)
        {
            _repo = repo;
        }

        public Response<CustomerTypeResponse?> Read(Key key)
        {
            try
            {
                var data = _repo.GetAll().Where(e=>e.Id==key.Id || e.Code==key.Code && e.IsDeleted==false).Select(e => new CustomerTypeResponse
                {
                    Code = e.Code,
                    Name = e.Name,
                });
                return Response<CustomerTypeResponse?>.Success();
            }catch(Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<CustomerTypeResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Where(e => e.IsDeleted == false).Select(e => new CustomerTypeResponse
                {
                    Code = e.Code,
                    Name = e.Name,
                }).OrderBy(e=>e.Code).ToList();
                return Response<List<CustomerTypeResponse>>.Success(data,data.Count(),"Successfullys");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Create(CustomerTypeCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Response<string> Delete(Key key)
        {
            throw new NotImplementedException();
        }


        public Response<string> Update(CustomerTypeUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICustomerTypeService : IService<CustomerTypeResponse, CustomerTypeCreateReq, CustomerTypeUpdateReq,Key>
    {
    }

    public class CustomerTypeUpdateReq : IUpdateReq
    {
    }

    public class CustomerTypeCreateReq : ICreateReq
    {
    }
}
