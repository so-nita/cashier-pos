using CashierPOS.Model.Models.Constant;

namespace CashierPOS.WebApi.Models.EntityModel;

public class Order 
{
    public string Id { get; set; } = null!;
    public decimal Sub_Total { get; set; }
    public decimal Total_Discount { get; set; }
    public decimal Grand_Total { get; set; }
    //public int Pos_Id { get; set; } 
    public int ShiftId { get; set; }  
    public decimal ExchangeRate { get; set; }   
    public string Reference_Id { get; set; } = null!;
    public string Company_Id { get; set; } = null!;
    public decimal? Tax { get; set; } = 0;
    public DateTime Order_Date { get; set; }
    public OrderStatus Order_Status { get; set; }
    public string? ReasonTypeId { get; set; }
    public DateTime? Cancelled_At { get; set; }
    public bool? Is_Deleted { get; set; }
    //--public string? Status { get; set; }
    public decimal? Received {  get; set; }
    public decimal? ReceivedKh {  get; set; }
    public decimal? Remaining { get; set; } = 0;
    public decimal? RemainingKh { get; set; } = 0;
    public decimal? Change { get; set; } = 0;
    public decimal? ChangeKh { get; set; } = 0;
    public string PaymentTypeCode { get; set; } = "";
    //public string SourceId { get; set; } = "";
    public string? SellType { get; set; } = "";
    public string? CustomerId { get; set; }
    //--public string CustomerTypeCode { get; set; } = "";
    public string CustomerType { get; set; } = "";
    public string PaymentMethodId { get; set; } = "";
    public decimal? Delivery { get; set; }
    public string DataSource { get; set; } = "";

    // Navigate association
    public ICollection<OrderPayment>? OrderPayments { get; set; } =new List<OrderPayment>();    
    public User? User { get; set; } = null!;
    public ICollection<OrderDetail>? OrderDetails { get; set; }
    //public Source? Source { get; set; }
    public ChangeShift ChangeShift { get; set; } = null!;
    public ICollection<SellInvoice>? SellInvoices { get; set; }  
}
