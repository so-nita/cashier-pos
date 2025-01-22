using CashierPOS.Model.Models.DiscountProduct;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Services;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IProductDiscountService
    {
        public Response<List<DiscountProductResponse>> ReadAll();
        //public Response<DiscountProductResponse> Read();
        public Response<string> Create(DiscountProductCreateReq request);
        public Response<string> Update(DicountProductUpdateReq request);
        public Response<string> ActiveDiscount(DiscountProductActiveReq request);
        public Response<string> InActiveDiscount(DiscountProductActiveReq request);
    }

    public class DiscountProductActiveReq
    {
        public string DiscountId { get; set; } = "";
    }
}
