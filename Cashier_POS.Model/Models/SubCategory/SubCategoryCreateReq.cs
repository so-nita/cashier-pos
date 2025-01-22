using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.SubCategory
{
    public class SubCategoryCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
        public string? Image { get; set; }
        public string Main_Category_Id { get; set; } = null!;
        public string? Description { get; set; }
        public Status Status { get; set; }
    }
}