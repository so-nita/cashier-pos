using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Menu
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Image { get; set; } = null!;
        public string? DivisionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
        //
        public Division? Division { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}
