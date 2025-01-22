using CashierPOS.WebApi.Interface;
using CashierPOS.Model.Interface;

namespace CashierPOS.Model.Models.Product
{
    public class ProductResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NameKh { get; set; }
        public string Sub_Category_Id { get; set; } = null!;
        public string? Division_Id { get; set; } = null!;
        //public string Sub_Category_Name { get; set; } = null!;
        //public int? BrandCode { get; set; }  
        public string? Brand { get; set; }  
        public decimal Tax { get; set; }
        public string? Size { get; set; }  
        public string? Image { get; set; }  
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string? Description { get; set; }
        public DateTime Create_At { get; set; }
        public string Status { get; set; }=null!;
        public string? ReasonCode { get; set; } = null!;
        public bool? Is_Deleted { get; set; }
    }
}
