using CashierPOS.Model.Models.Customer;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Service;
using CashierPOS.UI.View_PopUp;

namespace CashierPOS.UI.View.View_PopUp.Customer
{
    public partial class PopUp_Customer : Form
    {
        public PopUp_Customer()
        {
            InitializeComponent();
            InitailizeDataCustomerApi();
        }

        private async void InitailizeDataCustomerApi()
        {
            var service = new CustomerService();
            _customers = await service.GetAll();
        }

        private void btnCreateNewCust_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
            var form = new PopUp_CreateNewCustomer();
            form.BringToFront();
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private List<CustomerResponse> _customers = new List<CustomerResponse>();
        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
            string data = txtCode.Text.Trim();
            if (data.Length >= 9)
            {
                CompareCustomerData(data);
                txtCode.SelectionStart = txtCode.TextLength;
            }
            if (data == "" || data.Length == 8)
            {
                ClearTextBox(txtCode);
            }
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            string formattedNumber = CustomStyle.FormatPhoneNumber(txtContact.Text);
            txtContact.Text = formattedNumber;
            txtContact.SelectionStart = txtContact.Text.Length;
            string data = txtContact.Text.Trim();
            if (data.Length >= 9)
            {
                CompareCustomerData(data);
            }
            if(data == "" || data.Length == 7)
            {
                ClearTextBox(txtContact);
            }
        }
        private void CompareCustomerData(string dataCompare)
        {
            var customer = _customers.FirstOrDefault(e => e.Contact?.ToLower() == dataCompare?.ToLower()
                            || e.CustomerCode?.ToLower() == dataCompare?.ToLower());

            if (customer != null)
            {
                txtCode.Text = customer.CustomerCode;
                txtContact.Text = customer.Contact;
                txtEarningPoint.Text = customer.EarningPoint.ToString() ?? "0";
                txtEarningAmount.Text = customer.EarningAmount.ToString() ?? "0";
                // Move cursor to the end of the text in txtCode TextBox
                txtCode.SelectionStart = txtCode.TextLength;
                // Move cursor to the end of the text in txtContact TextBox
                txtCode.SelectionStart = txtContact.TextLength;
            }
        }

        private void ClearTextBox(System.Windows.Forms.TextBox textBox)
        {
            if(textBox.Name == txtCode.Name)
            {
                txtContact.Clear();
            }
            else
            {
                txtCode.Clear();
            }
            txtEarningPoint.Clear();
            txtEarningAmount.Clear();
        }
    }
}
