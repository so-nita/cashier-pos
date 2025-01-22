using CashierPOS.UI.Service;
using CashierPOS.UI.UserControls;
using CashierPOS.UI.View_PopUp;
using Microsoft.IdentityModel.Tokens;

namespace CashierPOS.UI.View.View_PopUp.PaymenMethod
{
    public partial class PopUp_PaymentMethod : Form
    {
        private readonly PopUp_PaymentOption _paymentOption;
        public string _paymenId { get; set; } = null!;

        public PopUp_PaymentMethod(PopUp_PaymentOption paymentOption)
        {
            _paymentOption = paymentOption;
            InitializeComponent();
            InitializeEventHandeler();
            InitializeData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SelectPaymentMethod();
        }

        private void SelectPaymentMethod()
        {
            if (_paymenId == null || _paymenId.ToString().IsNullOrEmpty())
            {
                MessageBox.Show("Please select payment", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _paymentOption.PaymentMethodId = _paymenId;
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private async void InitializeData()
        {
            var service = new PaymentMethodService();
            var data = await service.GetAllPaymentForPayAsync();
            foreach (var item in data)
            {
                var btn = new UC_PaymentMethod(item);
                btn.lbPaymentName.Click += LbPaymentImg_MouseEnter;
                btn.lbPaymentImg.Click += LbPaymentImg_MouseEnter;
                panelPaymentList.Controls.Add(btn);
            }
        }

        private void LbPaymentImg_MouseEnter(object? sender, EventArgs e)
        {
            OnMouseEnter(sender!);
        }

        public event EventHandler<bool> IsCancel = null!;
        private void OnMouseEnter(object sender)
        {
            // Get the parent UserControl (UC_PaymentMethod) of the sender
            UC_PaymentMethod clickedPaymentCard = FindParentUC_PaymentMethod((Control)sender);

            if (clickedPaymentCard != null)
            {
                // Iterate through each control in the panel
                foreach (Control control in panelPaymentList.Controls)
                {
                    // Check if the control is a UC_PaymentMethod
                    if (control is UC_PaymentMethod paymentCard)
                    {
                        // Set the border style of the clicked control to FixedSingle
                        if (paymentCard == clickedPaymentCard)
                        {
                            //_paymenId = paymentCard.GetPaymentId;
                            _paymenId = paymentCard.GetPaymentId;
                            paymentCard.BorderStyle = BorderStyle.FixedSingle;
                        }
                        else
                        {
                            // Set the border style of other controls to None
                            paymentCard.BorderStyle = BorderStyle.None;
                        }
                    }
                }
            }
        }
        private UC_PaymentMethod FindParentUC_PaymentMethod(Control control)
        {
            // Traverse up the control hierarchy to find the parent UC_PaymentMethod control
            while (control != null)
            {
                if (control is UC_PaymentMethod)
                {
                    return (UC_PaymentMethod)control;
                }
                control = control.Parent!;
            }
            return null!;
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            ClosedForm(sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClosedForm(sender);
        }

        private void ClosedForm(object sender)
        {
            IsCancel(sender, false);
            this.Close();
            //PopUp_Background.ClosePopUp();
        }
    }
}