using CashierPOS.Model.Models.Constant;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class PaymentMethod
    {
        public string Id { get; set; } = null!;
        /*--[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }*/
        public string Name { get; set; } = string.Empty;
        public string? Currency {  get; set; } = string.Empty;
        public string? Logo {  get; set; }
        public DateTime Create_At { get; set; } 
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
        //
        public ICollection<ChangeShiftDetail>? ChangeShiftDetails { get; set; }
       // public ICollection<OrderPayment>? OrderPayments { get; set; }
    }
}
