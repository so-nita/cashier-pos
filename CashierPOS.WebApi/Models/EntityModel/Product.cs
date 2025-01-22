using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel;

public class Product  
{
    public string Id { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? NameKh { get; set; } = null!;
    public string? Create_By { get; set; }  
    public string? Company_Id { get; set; } = null!;
    //public string Company_Name { get; set; } = null!;
    public string? Category_Id { get; set; }  
    public string? Brand {  get; set; }
    //public int? Brand_Code { get; set; }  
    public string? Image { get; set; } = null!;
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public int Qty { get; set; } =0;
    public string? Size { get; set; }
    public Tax Tax { get; set; }
    public DateTime? ExpiredDate { get; set; }    
    public string? Description { get; set; }
    public DateTime Create_At { get; set; }
    public DateTime? Updated_At { get; set; } = null;
    //public Status Status { get; set; }
    public string Status { get; set; } = "";
    public bool? Is_Deleted { get; set; }
    //
    public ICollection<OrderDetail>? OrderDetails { get; set; }
    public SubCategory SubCategory { get; set; } = null!;
    public User User { get; set; } = null!;
    public Company? Company { get; set; } = null!;
    //--public Brand Brand { get; set; } = null!;
    public ICollection<ProductDiscount>? ProductDiscounts { get; set; }
}

