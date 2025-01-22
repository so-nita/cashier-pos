using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Customer
    {
        public string Id { get; set; } = "";
        public string Code { get; set; } = "";
        //--public string Password { get; set; } = "";
        public string Name { get; set; } = "";
        public string? Contact { get; set; } = "";
        public string? CompanyId { get; set; }
        public string? CustomerTypeCode { get; set; }  
        public int? EarningPoint { get; set; }
        public decimal? EarningAmount { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        //public Gender Gender { get; set; }
        public string? Gender { get; set; }
        //public Nationality Nationality { get; set; }
        public string? Nationality { get; set; }
        public DateTime CreatedAt { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
        //
       // public ICollection<OrderPayment>? OrderPayments { get; set; }
    }
}
