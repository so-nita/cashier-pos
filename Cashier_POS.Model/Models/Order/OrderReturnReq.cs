using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.WebApi.Interface;

public class OrderReturnReq
{
    public string InvoiceNo { get; set; } = "";
    public string? ProductCode { get; set; } = "";
    public string ReasonReturnId { get; set; } = "";
    public string ApprovedByUserId { get; set; } = "";
    //--
    public List<string>? ProductIds { get; set; }
}
