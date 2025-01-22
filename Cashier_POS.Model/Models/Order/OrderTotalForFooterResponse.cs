using CashierPOS.Model.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Model
{
    public class OrderTotalForFooterResponse
    {
        public DateTime OrderDate { get; set; }
        public decimal SubTotal { get; set; } = 0.00m;
        public decimal SubTotal_Kh { get; set; } = 0.00m;
        public decimal? Discount { get; set; } = 0.00m;
        public decimal? Discount_Kh { get; set; } = 0.00m;
        public decimal? Deliery_Fee { get; set; } = 0.00m;
        public decimal? Deliery_Fee_Kh { get; set; } = 0.00m;
        public decimal TotalKhr { get; set; }
        public decimal Total { get; set; } = 0.00m;
        //public decimal ExchangeRate { get; set; }
        //public string OrderId { get; set; }
        public OrderStatus? OrderStatus { get; set; }
    }
}
