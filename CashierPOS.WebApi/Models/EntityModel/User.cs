using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class User  
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Name { get; set; }=null!;
        public string? Gender { get; set; } 
        public string? Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string? Contact { get; set; }  
        public string? Image { get; set; }
        public string Company_Id { get; set; } = "";
        public string User_Role { get; set; } = "";
        public string? Address { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        public string? Token { get; set; }
        // 
        public Company Company { get; set; }=null!;
        public ICollection<Order>? Orders { get; set; } 
        public ICollection<UserLog>? UserLog { get; set; }
        public ICollection<OrderPayment>? OrderPayments { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<ChangeShift>? ChangShifts { get; set; }
        public ICollection<ReturnOrder>? ReturnOrders { get; set; }
    }
}