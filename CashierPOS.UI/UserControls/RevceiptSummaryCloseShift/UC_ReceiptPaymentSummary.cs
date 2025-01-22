using CashierPOS.Model.Models.ChangeShift;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_ReceiptPaymentSummary : UserControl
    {
        //public IModel _getData;
        private SellPaymentMethod _payment;
        public UC_ReceiptPaymentSummary()
        {
            InitializeComponent();
        }
        public SellPaymentMethod Payment
        {
            get { return _payment; }
            set
            {
                _payment = value;
                InitData();
            }
        }
        private async void InitData()
        {
            if (_payment != null)
            {
                lbPaymentType.Text = Payment.PaymentName;
                lbQty.Text = Payment.Qty.ToString();
                lbTotal.Text = "$ " + Payment.Amount.ToString();
            }
        }
    }
}