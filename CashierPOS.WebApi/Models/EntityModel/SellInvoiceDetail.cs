namespace CashierPOS.WebApi.Models.EntityModel
{
    public class SellInvoiceDetail
    {
        public string Id { get; set; } = "";
        public string InvoiceId { get; set; } = "";
        public string InvoiceNo { get; set; } = "";
        public int Version { get; set; }    
        public DateTime PrintDate { get; set; }
        public string ByUserId { get; set; } = "";
        public int PosId { get; set; }

        /* public string? ApproveBy { get; set; } = "";
         public string? ReasonTypeCode { get; set; } = "";*/
        public string? Data { get; set; } = "";
        //
        public SellInvoice Invoice { get; set; } = null!;
    }
}
