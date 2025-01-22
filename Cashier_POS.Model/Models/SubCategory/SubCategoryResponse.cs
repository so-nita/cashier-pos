using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.SubCategory
{
    public class SubCategoryResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Main_Category_Id { get; set; } = null!;
        public string Main_Category_Name { get; set; } = null!; 
        public string? Image { get; set; }
        //public string? Description { get; set; }
        public DateTime Create_At { get; set; }
        public string Status { get; set; } = "";
        public bool? Is_Deleted { get; set; }
    }
}