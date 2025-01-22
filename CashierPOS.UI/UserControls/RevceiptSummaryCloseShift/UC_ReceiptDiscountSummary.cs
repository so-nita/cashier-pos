using CashierPOS.Model.Models.ChangeShift;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_ReceiptDiscountSummary : UserControl
    {
        private DiscountSummary _discount = null!;
        public UC_ReceiptDiscountSummary(string discountType)
        {
            InitializeComponent();
            _discountType = discountType;
        }

        public DiscountSummary Payment
        {
            get { return _discount; }
            set
            {
                _discount = value;
                InitializeData();
            }
        }

        private string _discountType = "";
        private void InitializeData()
        {
            if (Payment != null)
            {
                var discountName = Convert.ToDecimal(Payment.Name);
                if (_discountType == "%")
                {
                    lbvalueDisType.Text = $"{discountName.ToString("N2")} {_discountType}";
                }
                else
                {
                    lbvalueDisType.Text = $"{_discountType} {discountName.ToString("N2")}";
                }
                lbvalueSKUQty.Text = Payment.Qty.ToString();
                lbValueDisTypeTotal.Text = "$ " + Payment.Amount.ToString();
            }
        }
    }
}