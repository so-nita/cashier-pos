using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.WebApi.Models.RequestModel.SellInvoice
{
    public class SellInvoiceResponse : IResponse
    {
        public string Id { get; set; } = "";
        public string InvoiceNo { get; set; } = "";
        public string? OldInvoiceNo { get; set; }  
        public int Pos_Id { get; set; }  
        public string OrderId { get; set; } = "";
        public decimal Total { get; set; } 
        public decimal? Tax { get; set; }    
        public decimal? TaxKh { get; set; }    
        public decimal? Discount { get; set; }
        public decimal Total_Kh {  get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? Received { get; set; }
        public decimal? ReceivedKh { get; set; }
        public decimal? Change {  get; set; }
        public decimal? ChangeKh {  get; set; }
        public decimal? DeliveryFee {  get; set; }
        public string Company_Name { get; set; } = "";
        public string Company_NameKh { get; set; } = "";
        public string Company_Address { get; set; } = "";
        public string Company_Contact { get; set; } = "";
        public string? Customer_Type { get; set; } = "";
        public string Cashier_Id { get; set; } = "";
        public string Cashier_Name { get; set; } = "";
        public string? Description { get; set; }    
        public DateTime Print_Date { get; set; } 
        public OrderStatus Status { get; set; }
        public List<OrderDetailResponse> OrderTransaction { get; set; } = new();
    }
}
