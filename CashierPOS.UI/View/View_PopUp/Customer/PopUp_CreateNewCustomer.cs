using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Customer;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Service;
using CashierPOS.UI.View_PopUp;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.View.View_PopUp.Customer
{
    public partial class PopUp_CreateNewCustomer : Form
    {
        public PopUp_CreateNewCustomer()
        {
            InitializeComponent();
            InitailizeData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidationInput()) return;

                var service = new CustomerService();
                var dataRequest = new CustomerCreateReq()
                {
                    Name = txtName.Text.Trim(),
                    Contact = txtContact.Text.Trim(),
                    CustomerTypeCode = CustomerTypes.Loyality,
                };
                var dataResponse = await service.CreateAsync(dataRequest);
                if (dataResponse.Status == (int)ResponseStatus.Success)
                {
                    this.Close();
                    PopUp_Background.ClosePopUp();
                    MessageBox.Show($"  {dataResponse.Message}  ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show($"  {dataResponse.Message}  ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<string> _dataErrors = new List<string>();
        private bool IsValidationInput()
        {
            _dataErrors.Clear();
            foreach (Control control in panelContent.Controls)
            {
                if (control is TextBox textBox && textBox.Text.Trim() == "")
                {
                    _dataErrors.Add(textBox.Name + "Main");   // Add main because when update to border red is update on Main textbox not textbox that input value
                }
                if (control is DungeonComboBox comboBox)
                {
                    if (comboBox.SelectedItem == "Select Gender" || comboBox.SelectedItem == null || comboBox.SelectedItem == "Select Nationality" || comboBox.SelectedItem == null)
                    {
                        _dataErrors.Add(comboBox.Name + "Main");
                    }
                }
            }
            if (_dataErrors.Count > 0)
            {
                UpdateTextboxBorderError();
                return false;
            }
            return true;
        }

        private void UpdateTextboxBorderError()
        {
            foreach (Control control in panelContent.Controls)
            {
                if (control is CyberTextBox textBox)
                {
                    // Check if the control's name exists in the dataErrors list
                    if (_dataErrors.Contains(textBox.Name))
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
        private void InitailizeData()
        {
            InitializeDataComponent();
            ActiveControl = txtName;
            DataComboGender();
            DataComboNationality();
        }
        private void DataComboGender()
        {
            // Clear existing items before adding new ones
            comboGender.Items.Clear();
            // Add the placeholder text as the first item
            comboGender.Items.Add("Select Gender");

            // Iterate over the Gender enum values and add them to the comboGender ComboBox
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                comboGender.Items.Add(item);
            }
            // Set the default selected item to the placeholder text
            comboGender.SelectedIndex = 0;
        }


        private void DataComboNationality()
        {
            // Clear existing items before adding new ones
            comboNationality.Items.Clear();
            // Add the placeholder text as the first item
            comboNationality.Items.Add("Select Nationality");
            // Iterate over the Nationality enum values and add them to the comboNationality ComboBox
            foreach (var item in Enum.GetValues(typeof(Nationality)))
            {
                comboNationality.Items.Add(item);
            }
            // Set the default selected item to the placeholder text
            comboNationality.SelectedIndex = 0;
        }

        private void comboGender_OnEnter(object sender, EventArgs e)
        {
            // Check if the selected item is the placeholder text
            if (comboGender.SelectedItem?.ToString() == "Select Gender")
            {
                // Remove the placeholder text from the ComboBox items
                comboGender.Items.RemoveAt(0);
            }
        }
        private void comboNationality_OnEnter(object sender, EventArgs e)
        {
            // Check if the selected item is the placeholder text
            if (comboNationality.SelectedItem?.ToString() == "Select Nationality")
            {
                // Remove the placeholder text from the ComboBox items
                comboNationality.Items.RemoveAt(0);
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            string formattedNumber = CustomStyle.FormatPhoneNumber(txtContact.Text);
            txtContact.Text = formattedNumber;
            txtContact.SelectionStart = txtContact.Text.Length;
        }

    }
}
