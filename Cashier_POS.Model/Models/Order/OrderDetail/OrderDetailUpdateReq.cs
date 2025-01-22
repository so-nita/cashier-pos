namespace CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

public class OrderDetailUpdateReq
{
    public string Id { get; set; } = null!;
    public string Product_Id { get; set; } = "";
    public decimal? Discount_Percent { get; set; }
    //public string Order_Id { get; set; } = string.Empty;
    //public string Product_Name { get; set; } = string.Empty;
    //public string? Size { get; set; } = string.Empty;
    //public decimal Price { get; set; }
    public int Qty { get; set; }

}
