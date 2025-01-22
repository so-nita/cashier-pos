using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_PaymentMethod : UserControl
    {
        private readonly PaymentMethodResponse _payment;
        public UC_PaymentMethod(PaymentMethodResponse payment)
        {
            InitializeComponent();
            _payment = payment;
            InitializeData();
        }

        private async void InitializeData()
        {
            if (_payment != null)
            {
                lbPaymentImg.Image = await CustomStyle.GetImageFromUrl(_payment.Logo!);
                lbPaymentName.Text = _payment.Name;
            }
        }

        public string GetPaymentId
        {
            //get { return _payment.Id; }
            get { return _payment.Id; }
        }
        private void lbPaymentImg_Click(object sender, EventArgs e)
        {
            GetPayment();
        }

        private void lbPaymentName_Click(object sender, EventArgs e)
        {
            GetPayment();
        }

        private void GetPayment()
        {
            

        }

        
    }
}
