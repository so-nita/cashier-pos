using CashierPOS.Model.Interface;

namespace CashierPOS.Model.Models
{
    public class Key : IDelete
    {
        public string? Id { get; set; } = "";
        public string? Code { get; set; }
    }
}
