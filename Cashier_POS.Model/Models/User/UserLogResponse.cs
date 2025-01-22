using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.User
{
    public class UserLogResponse
    {
        public int PosId { get; set; }
        public int UserLogId { get; set; }  
        public string UserId { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Name { get; set; } = "";
        public string? Image {  get; set; } = null; 
        public string CompanyId { get; set; } = "";
        public int ShiftId { get; set; }  
        public decimal ExchangeRate { get; set; } = 0.00m;
        public decimal? SaleExchangeRate { get; set; } = 0.00m;
        public ShiftStatus ShiftStatus { get; set; }
    }
}
