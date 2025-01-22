using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.User;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.View;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_Logout : Form
    {
        public IMainView _mainView;

        public PopUp_Logout(IMainView mainView)
        {
            InitializeComponent();
            _mainView = mainView;
            InitializeDataComponent();
        }

        public event EventHandler<bool> LogoutStatusChanged;
        //Function Logout
        private async void btnLogout_Click(object sender, EventArgs e)
        {
            var userResponse = await CheckIsLogoutSuccess();
            if (userResponse.Status == (int)ResponseStatus.Success && userResponse.Total > 0)
            {
                //MessageBox.Show(userResponse.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogoutStatusChanged?.Invoke(this, true);
                this.Close();
                PopUp_Background.ClosePopUp();
            }
            else
            {
                LogoutStatusChanged?.Invoke(this, false);
                MessageBox.Show(userResponse.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<Response<string>> CheckIsLogoutSuccess()
        {
            var user = AppStoreContext.CurrentUser;
            if (user == null)
            {
                MessageBox.Show("Something went wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var userReq = new UserLogoutReq()
            {
                //PosId = user!.PosId
                UserLogId = user!.UserLogId
            };
            var service = new UserService();
            var userResponse = await service.GetUserLogout(userReq);
            return userResponse;
        }

        //Function Cancel Logout form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }

        //Function Close Logout form
        private void btnCloseLogout_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }
    }
}
