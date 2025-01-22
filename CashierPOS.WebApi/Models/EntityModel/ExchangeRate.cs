using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class ExchangeRate
    {
        public string Id { get; set; } = "";
        public decimal Value { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime? Last_Updated { get; set; }
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
    }
}
