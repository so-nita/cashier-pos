using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Category
{
    public class CategoryUpdateReq : IUpdateReq
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; } = null!;
        public string? Image { get; set; }
        public string? Description { get; set; }
        public Status? Status { get; set; }
    }
}
