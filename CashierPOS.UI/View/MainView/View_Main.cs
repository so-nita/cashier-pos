using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.UserControls;
using CashierPOS.UI.View_Content_Cashier;
using TestReceipt;

namespace CashierPOS.UI.View
{
    public partial class View_Main : Form, IMainView
    {
        private view_Content_Cashier _content;

        public View_Main()
        {
            InitializeComponent();
            _content = new view_Content_Cashier(this);
            AddController(_content);
        }


        public Action<string> SearchItem { get; set; }

        public void AddController(Form form)
        {
            this.panelCenter.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(form);
            form.Show();
        }

        public void CloseView()
        {
            _content.SetIsLogout(true);
            LoadData();
            _content.LoadData();
            AddController(_content);
        }

        public void LoadData()
        {
            InitializeData();
        }

        private async void InitializeData()
        {
            var user = AppStoreContext.CurrentUser;

            if (user != null)
            {
                picUserProfile.Image = await CustomStyle.GetImageFromUrl(user.Image!);
                labelPOSID.Text = user.PosId.ToString();
                labelUserID.Text = user.UserName;
                labelUserName.Text = user.Name;
                lbUserId.Text = "USER ID :";
                lbPosId.Text = "POS ID :";
            }
            else
            {
                picUserProfile.Image = null;
                labelPOSID.Text = null;
                labelUserID.Text = null;
                labelUserName.Text = null;
                lbUserId.Text = null;
                lbPosId.Text = null;
            }

            InitializeTimer();
        }

        private void InitializeTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick!;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbCurrentDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  hh:mm:ss tt");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && SearchItem != null)
            {
                SearchItem(textBox.Text);
            }
        }


        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            if (_content.IsLogout)
            {
                Application.Exit();
                return;
            }
            MessageBox.Show("Please logout before exit aplication", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}