using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.ChangeShift
{
    public class TransactionTypeSummary
    {
        public string Transaction { get; set; } = "";
        public int Qty { get; set; }
        public decimal? Total { get; set; }
    }
}
