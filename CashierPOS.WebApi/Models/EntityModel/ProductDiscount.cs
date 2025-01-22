using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ProductDiscount
    {
        public string Id { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string DiscountId { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Status Status { get; set; }
        public bool? IsDeleted { get; set; }

        // 
        public Product Product { get; set; } = null!;
        public DiscountType DiscountType { get; set; } = null!;
    }
}
