using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.Order
{
    public class HoldOrderResponse : ICreateReq
    {
        //public int PosId { get; set; }
        public int ShiftId { get; set; }
        public string OrderId { get; set; } = "";
        public decimal ExchangeRate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal Total { get; set; }
        public decimal TotalKh { get; set; }
        public DateTime OrderDate { get; set; }
        //public bool? Is_Delete { get; set; }
        public ICollection<OrderDetailResponse>? OrderDetails { get; set; }
    }
 
}
