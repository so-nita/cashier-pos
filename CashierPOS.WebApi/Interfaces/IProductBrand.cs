using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Brand;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IProductBrand : IService<BrandResponse, BrandCreateReq, BrandUpdateReq, BrandDeleteReq>
    {

    }
}
