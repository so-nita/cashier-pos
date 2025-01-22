using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Product;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.WebApi.Interface.Product;

public interface IProductService : IService<ProductResponse,ProductCreateReq, ProductUpdateReq,Key>
{
    public Response<List<ProductResponse>>? GetProductSell();
}