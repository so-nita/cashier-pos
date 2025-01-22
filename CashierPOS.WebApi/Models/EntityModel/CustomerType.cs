using CashierPOS.Model.Models.Constant;
using Microsoft.EntityFrameworkCore;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class CustomerType 
    {
        public string Id { get; set; } = "";
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public string? NameKh { get; set; } = "";
        public string? Description { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
        //
        public ICollection<OrderPayment>? OrderPayments { get; set; }
    }
}
