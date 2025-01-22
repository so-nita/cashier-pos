using CashierPOS.Model.Interface;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.Model.Models.RequestModel.Order
{
    public class OrderDeleteReq : IDelete
    {
        public string? Id { get; set; }
        public ICollection<OrderDetailDeleteReq>? OrderDetails { get; set; }
    }
}
