using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.ChangeShift
{
    public class DiscountSummary
    {
        public string DiscountType { get; set; } = "";
        public int Qty { get; set; }
        public string Name { get; set; } = "";
        public decimal Amount { get; set; }
    }

    public class DiscountTypeSummary
    {
        public ICollection<DiscountSummary>? DiscountPercentage { get; set; }
        public ICollection<DiscountSummary>? DiscountAmounts { get; set; }
    }


    public class CashPayment
    {
        public decimal TotalChange {  get; set; }
        public decimal CashPaymentReil { get; set; }
        public int QtyCashInReil { get; set; }
        public decimal CashPaymentDollar { get; set; }
        public int QtyCashInDollar { get; set; }
    }
}
