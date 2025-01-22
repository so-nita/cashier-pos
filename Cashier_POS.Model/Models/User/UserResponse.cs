using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.User
{
    public class UserResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = "";
        public string Name { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? Email { get; set; } = "";
        public string Contact { get; set; } = "";
        public string? Image { get; set; }
        public string Company_Id { get; set; } = "";
        public string Company_Name { get; set; } = "";
        public decimal ExchangeRate { get; set; }   
        public decimal? SaleExchangeRate { get; set; }   
        //--public string Role_Id { get; set; } = "";
        public string User_Role { get; set; } = "";
        public string? Address { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        public string? Token { get; set; }
    }
}
