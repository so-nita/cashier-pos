using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.Model.Models.Order
{
    public class ReturnOrderResponse
    {
        //public int PosId { get; set; } 
        public int ShiftId { get; set; } 
        public string InvoiveId { get; set; } = "";
        public string InvoiveNo { get; set; } = "";
        public string OrderId { get; set; } = "";
        public string ReasonReturnId { get; set; } = "";
        //--public string CustomerTypeCode { get; set; } = "";
        //--public string SourceId { get; set; } = "";
        public decimal Total {  get; set; } 
        public decimal TotalKh { get; set; }
        public Decimal ExchangeRate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerContact { get; set; }
        //--public string? GiftCounponId { get; set; }
        public Decimal? Exarning { get; set; }
        //public Gender? Gender { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        //public Nationality? Nationality { get; set; }
        public DateTime OrderDate { get; set; }  
        public OrderStatus OrderStatus { get; set; }
        public string? ProductCode { get; set; }  
        public string ApprovedByUserId { get; set; } = "";
        public ICollection<OrderDetailResponse>? Details { get; set; }=new List<OrderDetailResponse>();
    }
}
