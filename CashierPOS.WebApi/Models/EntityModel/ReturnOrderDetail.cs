namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ReturnOrderDetail
    {
        public string Id { get; set; } = "";
        public string ReturnId { get; set; } = "";
        public string ProductId { get; set; } = "";
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Sub_Amount { get; set; }
        public decimal Total { get; set; }
        public string ProductCode { get; set; } = "";
        //public string ProductName { get; set; } = string.Empty;
        //public string? Size { get; set; } = string.Empty;
        public decimal? Discount_Percent { get; set; }
        public decimal? Discount_Amount { get; set; }
        public decimal? Total_Discount { get; set; }
        public int? Reason_Id { get; set; } 
        //
        public ReturnOrder ReturnOrder { get; set; } = null!;
    }
}
