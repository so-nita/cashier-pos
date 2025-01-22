using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.User;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using ReaLTaiizor.Controls;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_ApproveCode : Form
    {
        private readonly IParentView _parentView;
        public bool BtnCancelClicked = false;
        public PopUp_ApproveCode(IParentView parentView = null!)
        {
            InitializeComponent();
            _parentView = parentView;
        }

        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            this.ActiveControl = txtboxCode;
            InitializeEventHandeler();
        }

        //Function for Cancel Form Approve Code
        private void btnCancle_Click(object sender, EventArgs e)
        {
            BtnCancelClicked = true;
            PopUp_Background.ClosePopUp();
        }

        //Function for Login Form Approve Code
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidValidation())
            {
                return;
            }

            var Code = txtboxCode.Text;
            var password = txtPassword.Text;

            var request = new UserLoginReq()
            {
                UserId = Code,
                Password = password,
            };

            var service = new UserService();
            var user = await service.GetUserApprove(request);

            if (user.Status == (int)ResponseStatus.Success)
            {
                AppStoreContext.SetUserApprove(user.Result!);
                PopUp_Background.ClosePopUp();
                this.Close();

                var form = new PopUp_Return(_parentView);
                PopUp_Background.Form = form;
                form.IsCancelReturn += CanceReturn_Click;

                PopUp_Background.ShowPopUp();
            }
            else
            {
                MessageBox.Show($"    {user.Message}        ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CanceReturn_Click(object? sender, bool e)
        {
            BtnCancelClicked = true;
        }

        //Function Hide Password when click 
        private void HidePassword()
        {
            if (_isShowPassword) // true
            {
                btnOpenEye.Text = "🔒";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnOpenEye.Text = "👁";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        //Function Close Form Approve Code
        private void btnCloseApproval_Click(object sender, EventArgs e)
        {
            BtnCancelClicked = true;
            PopUp_Background.ClosePopUp();
        }
        private List<string> dataErrors = new List<string>();
        private bool IsValidValidation()
        {
            dataErrors.Clear();
            foreach (Control control in panelApprovalCodeForm.Controls)
            {
                if (control is TextBox textBox && textBox.Text.Trim() == "")
                {
                    dataErrors.Add(textBox.Name + "Main");   // Add main because when update to border red is update on Main textbox not textbox that input value
                }
            }
            if (dataErrors.Count > 0)
            {
                UpdateTextboxBorderError();
                return false;
            }
            return true;
        }

        private void UpdateTextboxBorderError()
        {
            foreach (Control control in panelApprovalCodeForm.Controls)
            {
                if (control is CyberTextBox textBox)
                {
                    // Check if the control's name exists in the dataErrors list
                    if (dataErrors.Contains(textBox.Name))
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
 
    }
}