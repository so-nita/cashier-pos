using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ReasonType
    {
        public string Id { get; set; } = "";
        //public string Code { get; set; } = "";
        public string Reason_Type { get; set; } = "";
        public string Name { get; set; } = "";
        public DateTime Create_At { get; set; } 
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
        //
        //public ICollection<Order>? Orders { get; set; }
    }
}
