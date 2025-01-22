using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Category
{
    public class CategoryCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
        public string? Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public Status Status { get; set; }
    }
}
