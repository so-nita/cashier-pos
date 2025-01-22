using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail
{
    public class OrderDetailResponse
    {
        public string? Id { get; set; } = null!;
        public string Product_Id { get; set; } = "";
        public string Product_Code { get; set; } = "";
        public string Product_Name { get; set; } = string.Empty;
        //public string? Product_NameKh { get; set; }  
        public string? Product_Image {  get; set; } = null!;
        public string? Size { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal? Discount_Percent { get; set; }
        public decimal? Discount_Amount { get; set; } = 0.00m;
        public decimal? Total_Discount { get; set; } = 0.00m;
        public decimal Sub_Amount { get; set; }
        public decimal Grand_Amount { get; set; }
        public string? ReasonCode { get; set; }
        public OrderItemStatus Status { get; set; } 
    }
}
