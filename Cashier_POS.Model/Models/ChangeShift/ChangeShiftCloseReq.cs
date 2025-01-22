using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.Model.Models.ChangeShift
{
    public class ChangeShiftCloseReq
    {
        //--public int PosId { get; set; }
        public int ShiftId { get; set; }
        //public ICollection<SellPaymentMethod> Payments { get; set; } = new List<SellPaymentMethod>();
        public ICollection<PaymentMethodCloseShiftReq> Payments { get; set; } = new List<PaymentMethodCloseShiftReq>();
    }
    public class PaymentMethodCloseShiftReq
    {
        public string PaymentId { get; set; } = "";
        public decimal? Amount { get; set; } = 0.00m;
    }
}
