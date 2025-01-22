

using CashierPOS.Model.Constants;
using CashierPOS.Model.Interface;

namespace CashierPOS.WebApi.Interface.Product
{
    public class ProductCreateReq : ICreateReq
    {
        //public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NameKh { get; set; }  
        public string Create_By { get; set; } = null!;
        public string Category_Id { get; set; } = null!;
        public string? Image { get; set; }  
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; } = "";
        public Tax Tax { get; set; }
        public string? Description { get; set; }
    }
}