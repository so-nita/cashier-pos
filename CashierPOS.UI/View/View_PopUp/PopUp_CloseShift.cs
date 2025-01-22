using CashierPOS.Model.Models.ChangeShift;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Service;
using Microsoft.IdentityModel.Tokens;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_CloseShift : Form
    {
        private List<PaymentMethodResponse> _paymentMethods = null!;

        public PopUp_CloseShift()
        {
            InitializeComponent();
            InitData();
        }

        //Function for Cancel Close Shift
        private void btnCancle_Click(object sender, EventArgs e)
        {
            PopUp_Background.Form = this;
            PopUp_Background.ClosePopUp();
            this.Close();
        }

        //Function for Save Close Shift
        public event EventHandler<bool> IsClosedShift = null!;
        private List<PaymentMethodResponse> _paymentNameErrors = new();
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var response = await GetValueCloseShift();
            if (response)
            {
                IsClosedShift(sender, true);
                Printer.OpenCashDrawer();
            }
            else
            {
                IsClosedShift(sender, false);
            }
        }
        private void ValidationInputPayment()
        {
            foreach (Control control in panelListPaymentMethod.Controls)
            {
                if (control is CyberTextBox textBox)
                {
                    // Check if any payment error corresponds to the current textBox
                    if (_paymentNameErrors.Any(e => e.Id == textBox.Name))
                    {
                        textBox.ColorBackground_Pen = Color.Red;
                    }
                    else
                    {
                        textBox.ColorBackground_Pen = Color.White;
                    }
                }
            }
        }

        //Function get Dynamic Label and Textbox
        private async void InitData()
        {
            var serice = new OrderPaymentService();
            _paymentMethods = await serice.GetPaymentMethods();

            foreach (var item in _paymentMethods)
            {
                CreateLabelPaymentName(item.Name);
                CreatePanelHoverTextBox(item);
            }
            panelCloseShiftForm.Height = 260 + panelListPaymentMethod.Height;
            this.Location = new Point(700, 200);
        }

        private List<PaymentMethodCloseShiftReq> CloseShiftDataRequest = new();

        // Function get all value Type oy Payment (6) 
        private async Task<bool> GetValueCloseShift()
        {
            var user = AppStoreContext.CurrentUser;
            _paymentNameErrors.Clear();

            foreach (Control control in panelListPaymentMethod.Controls)
            {
                if (control is TextBox textBox)
                {
                    var data = _paymentMethods.First(e => e.Id == textBox.Name!.ToString());
                    if (data != null)
                    {
                        if (textBox.Text == "" || textBox.Text == "$ 0.00" || textBox.Text.IsNullOrEmpty())
                        {
                            _paymentNameErrors.Add(data);
                        }
                        decimal amount = 0.00m;
                        if (textBox.Tag!.ToString()!.Contains("KHR"))
                        {
                            amount = CustomStyle.ConvertStringToDecimal(textBox.Text, "​៛");
                        }
                        else
                        {
                            amount = CustomStyle.ConvertStringToDecimal(textBox.Text, "$");
                        }

                        CloseShiftDataRequest.Add(new PaymentMethodCloseShiftReq()
                        {
                            PaymentId = data.Id,
                            Amount = amount 
                        });
                    }
                }
            }

            var dataCloseShift = new ChangeShiftCloseReq()
            {
                ShiftId = user.ShiftId,
                Payments = CloseShiftDataRequest,
            };

            if (_paymentNameErrors.Count > 0)
            {
                ValidationInputPayment();
                return false;
            }
            var _service = new ChangeShiftService();
            var dataResponse = await _service.CloseShift(dataCloseShift);

            if (dataResponse != null)
            {
                PopUp_Background.Form = this;
                PopUp_Background.ClosePopUp();
                this.Close();
                AppStoreContext.CurrentUser.ShiftStatus = ShiftStatus.Close;
                return true;
            }
            else
            {
                MessageBox.Show("Close Shift Failed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Convert Sring to Decimal
        private decimal ConvertStringToDecimal(string value)
        {
            string cleanedValue = value.Replace("$ 0.00", "");
            return (decimal.TryParse(cleanedValue, out decimal result)) ? result : 0;
        }

        // Validation input Only Number for Textbox
        public void ValidationNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Check if the pressed key is a control key (like Backspace), a digit, or a period
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                // Allow only one decimal point
                if (e.KeyChar == '.' && textBox.Text.Contains('.'))
                {
                    e.Handled = true;
                }
                // Prevent entering more than two digits after the decimal point
                if (char.IsDigit(e.KeyChar) && textBox.Text.Contains('.'))
                {
                    string[] parts = textBox.Text.Split('.');
                    if (parts.Length > 1 && parts[1].Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        //Function Close form Close Shift
        private void btnCloseShift_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }
    }
}