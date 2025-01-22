using CashierPOS.Model.Constants;
using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;

namespace CashierPOS.Model.Models.Order;

public class OrderCreateReq : ICreateReq
{
    //public int Pos_Id { get; set; }  
    public int ShiftId { get; set; }  
    public OrderStatus Order_Status { get; set; }
    //public decimal Tax { get; set; }
    public decimal? DeleveryFee { get; set; }
    /**/
    public string? CustomerId { get; set; }
    //public string Order_Id { get; set; } = "";
    public decimal? Received { get; set; } = 0;
    public decimal? ReceivedKh { get; set; } = 0;
    public decimal? Remaining { get; set; } = 0;
    public decimal? RemainingKh { get; set; } = 0;
    public decimal? Change { get; set; } = 0;
    public decimal? ChangeKh { get; set; } = 0;
    public string? PaymentTypeCode { get; set; } = "";
    //public string? SourceId { get; set; } = "";
    public SellType SellType { get; set; }
    //public string? CustomerTypeCode { get; set; } = "";
    public CustomerTypes? CustomerType { get; set; }  
    public string? PaymentMethodId { get; set; } = "";
    public string? ReasonTypeId { get; set; }
    /**/
    public List<OrderDetailCreateReq> OrderDetails { get; set; } = new ();
}


public class OrderWithInvoiceCreateReq  
{
    //--public int Pos_Id { get; set; }
    public int Shift_Id { get; set; }
    public OrderStatus Order_Status { get; set; }
    public decimal? DeleveryFee { get; set; }
    public List<OrderDetailCreateReq> OrderDetails { get; set; } = new();
}

public class OrderDetailCreateReq
{
    public string Product_Id { get; set; } = "";
    public decimal? Discount_Percent { get; set; }
    public decimal? Discount_Amount { get; set; }
    public decimal Price { get; set; }  
    public int Qty { get; set; }  
    public OrderItemStatus? Status { get; set; }
    public string? ReasonCode { get; set; }  
}