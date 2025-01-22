using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class OrderPayment
    {
        public string Id { get; set; } = "";
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
        public string Order_Id { get; set; } = "";
        public decimal? Discount { get; set; }
        public decimal? DiscountName { get; set; }
        public decimal Total { get; set; }
        public decimal Total_Kh { get; set; }
        public decimal? Received { get; set; }
        public decimal? ReceivedKh { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? RemainingKh { get; set; }
        public decimal? Change { get; set; }
        public decimal? ChangeKh { get; set; }
        public decimal Exchange_Rate { get; set; }
        public string Reference { get; set; } = "";
        public DateTime Transaction_Date { get; set; }
        public string PaymentTypeName { get; set; } = "";
        public string PaymentCode { get; set; } = "";
        public string PaymentTypeId { get; set; } = "";
        //public int? PaymentMethod_Code { get; set; } 
        public string? PaymentMethodId { get; set; } 
        public string SourceId { get; set; } = "";
        public string CustomerTypeId { get; set; } = "";
        public string? CustomerCode { get; set; }  
        public PaymentStatus Status {  get; set; }  
        //
        public Order Order { get; set; } = null!;
        public User User { get; set; } = null!;
        //public PaymentMethod PaymentMethod { get; set; } = null!;
        public Source Source { get; set; } = null!;
        public PaymentType PaymentType { get; set; } = null!;
        public CustomerType CustomerType { get; set; } = null!;
        //public ICollection<SellInvoice>? SellInvoices { get; set;} 
        //public Customer Customer { get; set; } = null!;
    }
}
