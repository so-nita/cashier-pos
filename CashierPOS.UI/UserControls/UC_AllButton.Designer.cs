using CashierPOS.Model.Models.Constant;
using System.Runtime.CompilerServices;

namespace CashierPOS.UI.UserControls
{
    partial class UC_AllButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        private void InitializeDataComponent()
        {
            
            // Button login click
            btnLogin.Click += btnLogin_Click;

            // Button Cancel click
            btnCancle.Click += btnCancle_Click;

            // Button print cashier report click
            btnCashier.Click += btnCashier_Click;

            btnStock.Click += btnStock_Click;

            DisableButton(false);
            UC_AllButton_Load();
        }

        private void DisableButton(bool action)
        {
            btnCancle.Enabled = action;
            btnCashier.Enabled = action;
            btnDiscount.Enabled = action;
            btnHoldOrder.Enabled = action;
            btnCancle.Enabled = action;
            btnPayment.Enabled = action;
            btnCustomer.Enabled = action;
            btnReprint.Enabled = action;
            btnOpenShift.Enabled = action;
            btnReturn.Enabled = action;
            btnStock.Enabled = action;
        }
        /// </summary>
        private void InitializeComponent()
        {
            panelAllButton = new Panel();
            btnStock = new ReaLTaiizor.Controls.HopeButton();
            btnCustomer = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            btnCashier = new ReaLTaiizor.Controls.HopeButton();
            btnReturn = new ReaLTaiizor.Controls.HopeButton();
            btnDiscount = new ReaLTaiizor.Controls.HopeButton();
            btnHoldOrder = new ReaLTaiizor.Controls.HopeButton();
            btnReprint = new ReaLTaiizor.Controls.HopeButton();
            btnPayment = new ReaLTaiizor.Controls.HopeButton();
            btnOpenShift = new ReaLTaiizor.Controls.HopeButton();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            panelAllButton.SuspendLayout();
            SuspendLayout();
            // 
            // panelAllButton
            // 
            panelAllButton.BackColor = Color.FromArgb(215, 234, 213);
            panelAllButton.Controls.Add(btnStock);
            panelAllButton.Controls.Add(btnCustomer);
            panelAllButton.Controls.Add(btnCancle);
            panelAllButton.Controls.Add(btnCashier);
            panelAllButton.Controls.Add(btnReturn);
            panelAllButton.Controls.Add(btnDiscount);
            panelAllButton.Controls.Add(btnHoldOrder);
            panelAllButton.Controls.Add(btnReprint);
            panelAllButton.Controls.Add(btnPayment);
            panelAllButton.Controls.Add(btnOpenShift);
            panelAllButton.Controls.Add(btnLogin);
            panelAllButton.Location = new Point(1, -2);
            panelAllButton.Name = "panelAllButton";
            panelAllButton.Size = new Size(386, 105);
            panelAllButton.TabIndex = 0;
            // 
            // btnStock
            // 
            btnStock.BorderColor = Color.FromArgb(220, 223, 230);
            btnStock.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnStock.DangerColor = Color.FromArgb(245, 108, 108);
            btnStock.DefaultColor = Color.FromArgb(255, 255, 255);
            btnStock.Font = new Font("Segoe UI", 9.75F);
            btnStock.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnStock.InfoColor = Color.FromArgb(144, 147, 153);
            btnStock.Location = new Point(291, 71);
            btnStock.Name = "btnStock";
            btnStock.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnStock.Size = new Size(91, 29);
            btnStock.SuccessColor = Color.FromArgb(103, 194, 58);
            btnStock.TabIndex = 24;
            btnStock.Text = "Stock";
            btnStock.TextColor = Color.White;
            btnStock.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnCustomer
            // 
            btnCustomer.BorderColor = Color.FromArgb(220, 223, 230);
            btnCustomer.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCustomer.DangerColor = Color.FromArgb(245, 108, 108);
            btnCustomer.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCustomer.Font = new Font("Segoe UI", 9.75F);
            btnCustomer.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCustomer.InfoColor = Color.FromArgb(144, 147, 153);
            btnCustomer.Location = new Point(194, 71);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnCustomer.Size = new Size(91, 29);
            btnCustomer.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCustomer.TabIndex = 23;
            btnCustomer.Text = "Customer";
            btnCustomer.TextColor = Color.White;
            btnCustomer.WarningColor = Color.FromArgb(230, 162, 60);
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCancle
            // 
            btnCancle.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancle.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancle.Font = new Font("Segoe UI", 9.75F);
            btnCancle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancle.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancle.Location = new Point(2, 3);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(91, 29);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 14;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnCashier
            // 
            btnCashier.BorderColor = Color.FromArgb(220, 223, 230);
            btnCashier.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCashier.DangerColor = Color.FromArgb(245, 108, 108);
            btnCashier.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCashier.Font = new Font("Segoe UI", 9.75F);
            btnCashier.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCashier.InfoColor = Color.FromArgb(144, 147, 153);
            btnCashier.Location = new Point(2, 71);
            btnCashier.Name = "btnCashier";
            btnCashier.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnCashier.Size = new Size(187, 29);
            btnCashier.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCashier.TabIndex = 22;
            btnCashier.Text = "Cashier Report";
            btnCashier.TextColor = Color.White;
            btnCashier.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnReturn
            // 
            btnReturn.BorderColor = Color.FromArgb(220, 223, 230);
            btnReturn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnReturn.DangerColor = Color.FromArgb(245, 108, 108);
            btnReturn.DefaultColor = Color.FromArgb(255, 255, 255);
            btnReturn.Font = new Font("Segoe UI", 9.75F);
            btnReturn.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnReturn.InfoColor = Color.FromArgb(144, 147, 153);
            btnReturn.Location = new Point(98, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.PrimaryColor = Color.Sienna;
            btnReturn.Size = new Size(91, 29);
            btnReturn.SuccessColor = Color.FromArgb(103, 194, 58);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Return";
            btnReturn.TextColor = Color.White;
            btnReturn.WarningColor = Color.FromArgb(230, 162, 60);
            btnReturn.Click += btnReturn_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.BorderColor = Color.FromArgb(220, 223, 230);
            btnDiscount.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDiscount.DangerColor = Color.FromArgb(245, 108, 108);
            btnDiscount.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDiscount.Font = new Font("Segoe UI", 9.75F);
            btnDiscount.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDiscount.InfoColor = Color.FromArgb(144, 147, 153);
            btnDiscount.Location = new Point(291, 37);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnDiscount.Size = new Size(91, 29);
            btnDiscount.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDiscount.TabIndex = 21;
            btnDiscount.Text = "Discount";
            btnDiscount.TextColor = Color.White;
            btnDiscount.WarningColor = Color.FromArgb(230, 162, 60);
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnHoldOrder
            // 
            btnHoldOrder.BorderColor = Color.FromArgb(220, 223, 230);
            btnHoldOrder.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnHoldOrder.DangerColor = Color.FromArgb(245, 108, 108);
            btnHoldOrder.DefaultColor = Color.FromArgb(255, 255, 255);
            btnHoldOrder.Font = new Font("Segoe UI", 9.75F);
            btnHoldOrder.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnHoldOrder.InfoColor = Color.FromArgb(144, 147, 153);
            btnHoldOrder.Location = new Point(194, 3);
            btnHoldOrder.Name = "btnHoldOrder";
            btnHoldOrder.PrimaryColor = Color.Gold;
            btnHoldOrder.Size = new Size(91, 29);
            btnHoldOrder.SuccessColor = Color.FromArgb(103, 194, 58);
            btnHoldOrder.TabIndex = 16;
            btnHoldOrder.Text = "Hold Order";
            btnHoldOrder.TextColor = Color.White;
            btnHoldOrder.WarningColor = Color.FromArgb(230, 162, 60);
            btnHoldOrder.Click += btnHoldOrder_Click;
            // 
            // btnReprint
            // 
            btnReprint.BorderColor = Color.FromArgb(220, 223, 230);
            btnReprint.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnReprint.DangerColor = Color.FromArgb(245, 108, 108);
            btnReprint.DefaultColor = Color.FromArgb(255, 255, 255);
            btnReprint.Font = new Font("Segoe UI", 9.75F);
            btnReprint.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnReprint.InfoColor = Color.FromArgb(144, 147, 153);
            btnReprint.Location = new Point(194, 37);
            btnReprint.Name = "btnReprint";
            btnReprint.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnReprint.Size = new Size(91, 29);
            btnReprint.SuccessColor = Color.FromArgb(103, 194, 58);
            btnReprint.TabIndex = 20;
            btnReprint.Text = "Reprint";
            btnReprint.TextColor = Color.White;
            btnReprint.WarningColor = Color.FromArgb(230, 162, 60);
            btnReprint.Click += btnReprint_Click;
            // 
            // btnPayment
            // 
            btnPayment.BorderColor = Color.FromArgb(220, 223, 230);
            btnPayment.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnPayment.DangerColor = Color.FromArgb(245, 108, 108);
            btnPayment.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPayment.Enabled = false;
            btnPayment.Font = new Font("Segoe UI", 9.75F);
            btnPayment.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPayment.InfoColor = Color.Gainsboro;
            btnPayment.Location = new Point(291, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.PrimaryColor = Color.SteelBlue;
            btnPayment.Size = new Size(91, 29);
            btnPayment.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPayment.TabIndex = 17;
            btnPayment.Text = "Payment";
            btnPayment.TextColor = Color.White;
            btnPayment.WarningColor = Color.FromArgb(230, 162, 60);
            btnPayment.Click += btnPayment_Click;
            // 
            // btnOpenShift
            // 
            btnOpenShift.BorderColor = Color.FromArgb(220, 223, 230);
            btnOpenShift.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnOpenShift.DangerColor = Color.FromArgb(245, 108, 108);
            btnOpenShift.DefaultColor = Color.FromArgb(255, 255, 255);
            btnOpenShift.Font = new Font("Segoe UI", 9.75F);
            btnOpenShift.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnOpenShift.InfoColor = Color.FromArgb(144, 147, 153);
            btnOpenShift.Location = new Point(98, 37);
            btnOpenShift.Name = "btnOpenShift";
            btnOpenShift.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnOpenShift.Size = new Size(91, 29);
            btnOpenShift.SuccessColor = Color.FromArgb(103, 194, 58);
            btnOpenShift.TabIndex = 19;
            btnOpenShift.Text = "Open Shift";
            btnOpenShift.TextColor = Color.White;
            btnOpenShift.WarningColor = Color.FromArgb(230, 162, 60);
            btnOpenShift.Click += btnOpenShift_Click;
            // 
            // btnLogin
            // 
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 9.75F);
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(2, 37);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnLogin.Size = new Size(91, 29);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // UC_AllButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelAllButton);
            Name = "UC_AllButton";
            Size = new Size(398, 104);
            panelAllButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        public void UC_AllButton_Load(bool canPay=false)
        {
            if (IsOpenShift)
            {
                btnCancle.Enabled = true;
                btnCashier.Enabled = true;
                btnDiscount.Enabled = true;
                btnHoldOrder.Enabled = true;
                btnCancle.Enabled = true;
                btnPayment.Enabled = true;
                btnCustomer.Enabled = true;
                btnReprint.Enabled = true;
                btnOpenShift.Enabled = true;
                btnReturn.Enabled = true;
                btnStock.Enabled = true;
            }
            else if (_isLog)
            {
                if(!IsUserLogged)
                {
                    btnOpenShift.Enabled = true;
                }
                //--btnOpenShift.Enabled = true;
                btnLogin.Text = "Logout";
                btnCashier.Enabled = IsUserLogged ? true : false;
            }
            else
            {
                btnOpenShift.Enabled = false;
            }
            EnableButtonPay(canPay);
        }

        #endregion

        private Panel panelAllButton;
        private ReaLTaiizor.Controls.HopeButton btnCustomer;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private ReaLTaiizor.Controls.HopeButton btnCashier;
        private ReaLTaiizor.Controls.HopeButton btnReturn;
        private ReaLTaiizor.Controls.HopeButton btnDiscount;
        private ReaLTaiizor.Controls.HopeButton btnHoldOrder;
        private ReaLTaiizor.Controls.HopeButton btnReprint;
        private ReaLTaiizor.Controls.HopeButton btnPayment;
        private ReaLTaiizor.Controls.HopeButton btnOpenShift;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
        private ReaLTaiizor.Controls.HopeButton btnStock;
        
        private static bool _isLog { get; set; } = false;
        public void SetIsLogin(bool value) => _isLog = value;


        public bool IsOpenShift { get; set; } = false;
        public bool IsReturn { get; set; } = false;
        public bool IsUserLogged { get; set; } = true;
        public bool IsUserLoggedOut { get; set; } = true;
    }
}