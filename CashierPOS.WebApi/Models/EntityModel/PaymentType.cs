using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class PaymentType
    {
        public string Id { get; set; } = "";
        public string PaymentCode { get; set; } = "";
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
        //
        public ICollection<OrderPayment>? OrderPayments { get; set; }
    }
}
