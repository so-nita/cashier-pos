using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.Customer
{
    public class CustomerResponse : IResponse
    {
        public string CustomerId { get; set; } = "";
        public string CustomerCode { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string? Contact { get; set; } = "";
        public decimal EarningPoint { get; set; } = 0;
        public decimal EarningAmount { get; set; } = 0;
        public string? Email { get; set; }
        public string? Gender { get; set; } = "";
        public string? Nationaltity { get; set; } = "";
    }

}
