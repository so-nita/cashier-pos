using CashierPOS.Model.Interface;

namespace CashierPOS.Model.Models.DiscountProduct
{
    public class DiscountProductCreateReq : ICreateReq
    {
        public string UserId { get; set; } = "";
        public string DiscountId { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public List<ProductDiscountCreateReq> Products { get; set; }= new ();
    }
    public class ProductDiscountCreateReq
    {
        public string ProductId { get; set; } = "";
    }
}
