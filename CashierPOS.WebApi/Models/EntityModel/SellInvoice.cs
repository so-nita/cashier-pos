using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class SellInvoice
    {
        public string Id { get; set; } = "";
        public string InvoiceNo { get; set; } = "";
        public string OrderId { get; set; } = "";
        //public int Pos_Id { get; set; }
        public int ShiftId { get; set; }
        public DateTime PrintDate { get; set; }
        public bool? IsPaid { get; set; }
        public string? OrderReturnId {  get; set; }
        public string? OldInvoiceNo { get; set; }
        public Status Status { get; set; }
        public bool? IsDeleted {  get; set; }
        //
        public Order Order { get; set; } = null!;
        //public OrderPayment OrderPayment { get; set; } = null!;
        public ICollection<SellInvoiceDetail>? InvoiceDetails { get; set; }
    }
}
