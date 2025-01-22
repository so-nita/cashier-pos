using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.User;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.Service;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_LoginForm : Form
    {
        public static Form _form;

        public event EventHandler LoginSuccess;
        public bool IsUserLog { get; set; } = false;

        public PopUp_LoginForm()
        {
            InitializeComponent();
        }

        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserID;
            InitializeEventHandeler();
        }


        //Show POP UP Form Login
        private void btnCancle_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }

        //Function Login 
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidValidation()) // Validation user was input all field
            {
                return;
            }
            var userLog = await CheckUserLog();
            if(userLog.Status == (int)ResponseStatus.Success)
            {
                if (AppStoreContext.CurrentUser != null)
                {
                    IsUserLog = true;
                    LoginSuccess?.Invoke(this, EventArgs.Empty);
                    this.Close();
                    PopUp_Background.ClosePopUp();
                }
                else
                {
                    this.Close();
                    PopUp_Background.ClosePopUp();
                }
                return;
            }
            MessageBox.Show($"      {userLog?.Message?? "   Login failed    "}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async Task<Response<UserLogResponse>> CheckUserLog()
        {
            var Username = txtUserID.Text;
            var password = txtPassword.Text;

            var request = new UserLoginReq()
            {
                UserId = Username,
                Password = password,
            };

            var service = new UserService();
            var user = await service.GetUserLogin(request);
            return user;
        }

        private List<string> dataErrors = new List<string>();
        private bool IsValidValidation()
        {
            dataErrors.Clear();
            foreach (Control control in panelLoginForm.Controls)
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
            foreach (Control control in panelLoginForm.Controls)
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

        //Function Close for Login Form
        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }
    }
}