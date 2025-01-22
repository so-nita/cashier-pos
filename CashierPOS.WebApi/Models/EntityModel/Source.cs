using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel;

public class Source
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string? Desctiption { get; set; }  
    public Status Status { get; set; }
    public DateTime Create_At { get; set; }
    public bool Is_Deleted { get; set;}
    //
    //public ICollection<Order>? Orders { get; set;}
    public ICollection<OrderPayment>? OrderPayments { get; set;}
}
