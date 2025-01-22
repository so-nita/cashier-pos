using CashierPOS.Model.Models.Constant;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Brand
    {
        public string Id { get; set; } = "";
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        //
       // public ICollection<Product>? Products { get; set; }
    }
}
