using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Order;

namespace CashierPOS.WebApi.Models.RequestModel.SellInvoice
{
    public class SellInvoiceCreateReq : ICreateReq
    {
        //public int OrderPayment_Code { get; set; }  
        public string OrderId { get; set; } = "";
        public string? InvoiceNo {  get; set; }
    }

    public class InvoiceCreateReq : ICreateReq
    {
        public string OrderId { get; set; } = "";
        public string? InvoiceNo { get; set; }
        public List<ReturnOrderDetailsId>? ReturnDetails { get; set; }
    }

    public class ReturnOrderDetailsId
    {
        public string ProductId { get; set; } = "";
    }
}
