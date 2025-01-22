
using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class OrderDetail
    {
        public string Id { get; set; } = null!;
        public string Order_Id { get; set; } = string.Empty;
        public string Product_Id { get; set; } = "";
        public string Product_Code { get; set; } = "";
        public decimal Price { get; set;}
        public int Qty { get; set;}
        public decimal? Discount_Percent { get; set;}
        public decimal? Discount_Amount { get; set; }
        public decimal? Total_Discount { get; set; }
        public decimal Sub_Amount { get; set;}
        public decimal Grand_Amount { get; set;}
        public OrderItemStatus Status { get; set; }
        public string? ReasonId { get; set; }
        public Tax TaxType { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime? SynData_At { get; set; }
        // 
        public Order Order { get; set; } = null!;
        public Product Product { get; set; }=null!;
    }
}
