using CashierPOS.Model.Interface;

namespace CashierPOS.WebApi.Models.RequestModel.Receipt
{
    public class OrderPaymentCreateReq : ICreateReq
    {
        public string Order_Id { get; set; } = "";
        public decimal? Received { get; set; } = 0;
        public decimal? ReceivedKh { get; set; } = 0;
        public decimal? Remaining { get; set; } = 0;
        public decimal? RemainingKh { get; set; } = 0;
        public decimal? Change { get; set; } = 0;
        public decimal? ChangeKh { get; set; } = 0;
        public string PaymentTypeCode { get; set; } = "";
        public string SourceId { get; set; } = "";
        public string? CustomerCode { get; set; } 
        public string CustomerTypeCode { get; set; } = "";
        //public int PaymentMethodCode { get; set; }
        public string PaymentMethodId { get; set; } = "";
    }
    public class OrderPaymentReturnReq  
    {
        public string OrderId { get; set; } = "";
        public string InvoiceNo { get; set; } = "";
        public string ProductCode { get; set; } = string.Empty;
        public string ApprovedBy { get; set; }= string.Empty;
    }
    public enum PaymentStatus
    {
        Paid = 1,
        Return = 2,
    }
}
