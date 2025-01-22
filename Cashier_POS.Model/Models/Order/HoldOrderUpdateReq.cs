using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Order
{
    public class HoldOrderUpdateReq
    {
        public string OrderId { get; set; } = string.Empty;
        public decimal? DeleveryFee { get; set; }
        public OrderStatus Status { get; set; }
        public string? CustomerId { get; set; }
        public decimal? Received { get; set; } = 0;
        public decimal? ReceivedKh { get; set; } = 0;
        public decimal? Remaining { get; set; } = 0;
        public decimal? RemainingKh { get; set; } = 0;
        public decimal? Change { get; set; } = 0;
        public decimal? ChangeKh { get; set; } = 0;
        public string? PaymentTypeCode { get; set; } = "";
        public SellType SellType { get; set; }
        public CustomerTypes? CustomerType { get; set; }
        public string? PaymentMethodId { get; set; } = "";
        /*public string? ReasonTypeId { get; set; }*/
        public ICollection<OrderDetailCreateReq>? OrderDetails { get; set; }
    }
}
