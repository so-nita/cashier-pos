using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel
{
    public class Company 
    {
        public string Id { get; set; } = null!;
        public int? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? NameKh {  get; set; }
        public string? Email { get; set; } = null!; 
        public string Contact { get; set; } = null!;
        public string System_Id { get; set; } =null!;
        public string? Image { get; set; } = null!;
        public string? Website { get; set; }    
        public string Address { get; set; } = null!;
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        public decimal Exchange_Rate { get; set; }
        public decimal? SaleExchangeRate { get; set; }
        //
        public ICollection<User>? Users { get; set; }
        public SystemType SystemType { get; set; } = null!;
        public ICollection<ChangeShift>? ChangShifts { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Division>? Divisions { get; set; }
    }
}
