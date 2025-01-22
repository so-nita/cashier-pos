using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Category
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Image { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public string? MenuId  { get; set; } 
        public DateTime Create_At { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
        // 
        public ICollection<SubCategory>? SubCategories { get; set; }
        public Menu? Menu { get; set; }
    }
}
