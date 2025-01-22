using CashierPOS.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.PaymentMethod
{
    public class PaymentMethodResponse : IResponse
    {
        public string Id { get; set; } = "";
        //public int Code { get; set; } 
        public string Name { get; set; } = "";
        public string Currency { get; set; } =string.Empty;
        public string? Logo { get; set; }
    }
}
