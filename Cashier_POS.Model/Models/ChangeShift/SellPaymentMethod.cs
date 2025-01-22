using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.ChangeShift
{
    public class SellPaymentMethod
    {
        public string PaymentName { get; set; } = "";
        public string PaymentId { get; set; } = "";
        public decimal? Amount { get; set; } = 0.00m;
        public int Qty { get; set; }
    }
}
