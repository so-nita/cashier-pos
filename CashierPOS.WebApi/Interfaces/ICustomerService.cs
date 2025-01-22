using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Customer;

namespace CashierPOS.WebApi.Interfaces
{
    public interface ICustomerService : IService<CustomerResponse, CustomerCreateReq, CustomerUpdateReq, CustomerDeleteReq>
    {
    }
}
