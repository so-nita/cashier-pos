using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.User;

public class UserCreateReq : ICreateReq
{
    //public string UserName { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Company_Id { get; set; } = "";
    //--public string Role_Id { get; set; } = "";
    public UserRole UserRole { get; set; }  
    public Gender? Gender { get; set; }
    public string? Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string Contact { get; set; } = "";
    public string? Image { get; set; }
    public string? Address { get; set; }
    //public Status Status { get; set; }
    public string Token { get; set; } = "";
}

public enum UserRole
{
    Admin ,
    Cashier,
    SuperAdmin
}
