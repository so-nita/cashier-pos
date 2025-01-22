using CashierPOS.Model.Interface;

namespace CashierPOS.WebApi.Models.RequestModel.Receipt
{
    public class OrderPaymentUpdateReq : IUpdateReq
    {
        public int Code { get; set; }  
        //public string Order_Id { get; set; } = "";
        public decimal? Received { get; set; } = 0;
        public decimal? Remaining { get; set; } = 0;
        public decimal? Change { get; set; } = 0;
        public string? PaymentTypeCode { get; set; } = "";
        public string? SourceId { get; set; } = "";
    }
}
