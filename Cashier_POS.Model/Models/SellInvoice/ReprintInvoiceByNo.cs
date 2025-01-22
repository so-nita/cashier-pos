namespace CashierPOS.WebApi.Models.RequestModel.SellInvoice
{
    public class ReprintInvoiceByNo
    {
        public int? ShiftId { get; set; }
        public string InvoiceNo { get; set; } = "";
    }
}
