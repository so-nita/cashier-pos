using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.User;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.View;
using CashierPOS.WebApi.Models.RequestModel.ChangeShift;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_OpenShift : Form
    {
        private IMainView _mainView;
        public PopUp_OpenShift(IMainView mainView)
        {
            InitializeComponent();
            _mainView = mainView;
        }

        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            this.ActiveControl = txtTotalCashUSD;
            InitializeEventHandeler();

            var user = AppStoreContext.CurrentUser;
            //AppStoreContext.SetCurrentUser(user);
            txtboxPosID.Text = user.PosId.ToString();
            txtboxCashierName.Text = user.Name;
            txtboxUserID.Text = user.UserName;
            txtboxOpenDate.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm tt");
        }

        //Function Cancel Open Shift
        private void btnCancle_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }

        private UserLogResponse GetUser
        {
            get
            {
                return AppStoreContext.CurrentUser;
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Validation user input for required field
            if (!IsValidValidation())
            {
                return;
            }
            // Check if user have been log 
            if (GetUser.ShiftStatus == ShiftStatus.Close)
            {
                await UserHaveLoggedAsync();
            }
            var service = new ChangeShiftService();
            var startBalaceKh = txtTotalCashKHR.Text.Trim().Replace(" ​៛", "");
            var dataReq = new ChangeShiftCreateReq()
            {
                //Pos_Id = GetUser.PosId,
                UserLogId = GetUser.UserLogId,
                Start_Balance = CustomStyle.ConvertStringToDecimal(txtTotalCashUSD.Text, "$"),
                Start_Balance_Kh = Convert.ToDecimal(startBalaceKh),
            };
            var openShiftResponse = await service.OpenChangeShift(dataReq);

            if (openShiftResponse?.Status != (int)ResponseStatus.Success)
            {
                MessageBox.Show(openShiftResponse?.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppStoreContext.CurrentUser.ShiftStatus = ShiftStatus.Open;
            AppStoreContext.CurrentUser.ShiftId = openShiftResponse.Result!.ShiftId;
            Printer.OpenCashDrawer();
            this.Close();
            PopUp_Background.ClosePopUp();

            var form = new View_POS(_mainView);
            _mainView.SearchItem += form.TxtSearchItemInProductSell_TextChanged;
            _mainView.AddController(form);
            PopUp_Background.Form = form;
        }

        private async Task<bool> UserHaveLoggedAsync()
        {
            var userService = new UserService();
            var request = new UserReponseShiftReq()
            {
                //PosId = GetUser.PosId,
                UserLogId = GetUser.UserLogId,
            };

            var user = await userService.GetUserReopenshift(request);
            if (user.Status != (int)ResponseStatus.Success)
            {
                return false;
            }
            return true;
        }

        //Function Close Open Shift
        private void btnCloseOpenShift_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private List<string> dataErrors = new List<string>();
        private bool IsValidValidation()
        {
            dataErrors.Clear();
            foreach (Control control in panelOpenShift.Controls)
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
            foreach (Control control in panelOpenShift.Controls)
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

        private void txtTotalCashUSD_TextChanged(object sender, EventArgs e)
        {
            string formattedNumber = CustomStyle.FormatAmountCurrency(txtTotalCashUSD.Text, " $");
            txtTotalCashUSD.Text = formattedNumber;
            if (txtTotalCashUSD.Text == " $" || txtTotalCashUSD.Text == "" || txtTotalCashUSD.Text == "$")
            {
                txtTotalCashUSD.Text = "";
                txtTotalCashUSD.SelectionStart = 0;
            }
            else  
            {
                txtTotalCashUSD.SelectionStart = txtTotalCashUSD.Text.Length;
            }
        }

        private void txtTotalCashKHR_TextChanged(object sender, EventArgs e)
        {
            string formattedNumber = CustomStyle.FormatAmountCurrency(txtTotalCashKHR.Text, " រ");
            txtTotalCashKHR.Text = formattedNumber;
            if (txtTotalCashKHR.Text == " ​៛" || txtTotalCashKHR.Text == "" || txtTotalCashKHR.Text== "៛")
            {
                txtTotalCashKHR.Text = "";
                txtTotalCashKHR.SelectionStart = 0;
            }
            else
            {
                txtTotalCashKHR.SelectionStart = txtTotalCashKHR.Text.Length - 2;
                var test = (txtTotalCashKHR.SelectionStart = txtTotalCashKHR.Text.Length - 3);
            }
        }
    }

}
