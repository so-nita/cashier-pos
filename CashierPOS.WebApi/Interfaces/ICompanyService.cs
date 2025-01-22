using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.WebApi.Models.RequestModel.Company;

namespace CashierPOS.WebApi.Interface;
public interface ICompanyService : IService<CompanyResponse,CompanyCreateReq,CompanyUpdateReq,Key>
{

}
