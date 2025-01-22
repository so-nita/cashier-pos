namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ReturnOrder
    {
        public string Id { get; set; } = "";
        //--public int Pos_Id { get; set; }
        public int ShiftId { get; set; }
        public string OrderId { get; set; } = "";
        public string InvoiceNo { get; set; } = "";
        public decimal Sub_Total { get; set; } = 0.00m;
        public decimal? Total_Discount { get; set; } = 0.00m;
        public decimal Grand_Total { get; set; } = 0.00m;
        public string ReturnReasonCode { get; set; } = "";
        public DateTime ReturnDate {  get; set; }
        public string ApprovedBy { get; set; } = "";
        public string ApprovedByUserName { get; set; } = "";
        // 
        public ICollection<ReturnOrderDetail>? Details { get; set; }
        public User User { get; set; } = null!;
    }
}
