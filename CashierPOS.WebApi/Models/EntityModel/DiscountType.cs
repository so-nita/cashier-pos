using CashierPOS.Model.Models.Constant;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class DiscountType
    {
        public string Id { get; set; } = "";
        /* [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }  */
        public string Name { get; set; } = "";
        public decimal DiscountPercent { get; set; }
        public DateTime StartAt { get; set; }   
        public DateTime? EndAt { get; set; }
        public string? Description { get; set; }
        public DateTime? CreateAt { get; set; } 
        public Status Status { get; set; }
        public bool ? IsDeleted { get; set; }
        // 
        public ICollection<ProductDiscount>? ProductDiscounts { get; set; }
    }
}
