using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View.View_PopUp.PaymenMethod
{
    partial class PopUp_PaymentMethod
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeEventHandeler()
        {
            btnCancle.Click += btnCancle_Click;
            btnClose.Click += btnClose_Click;
            btnPay.Click += btnPay_Click;
            
           
        }

        /// </summary>
        private void InitializeComponent()
        {
            panelLoginForm = new Panel();
            panelPaymentList = new FlowLayoutPanel();
            btnPay = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderLogin = new Panel();
            btnClose = new Button();
            lbNameLogin = new Label();
            panelLoginForm.SuspendLayout();
            panelHeaderLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLoginForm
            // 
            panelLoginForm.BackColor = Color.White;
            panelLoginForm.Controls.Add(panelPaymentList);
            panelLoginForm.Controls.Add(btnPay);
            panelLoginForm.Controls.Add(btnCancle);
            panelLoginForm.Controls.Add(panelHeaderLogin);
            panelLoginForm.Dock = DockStyle.Fill;
            panelLoginForm.Location = new Point(0, 0);
            panelLoginForm.Name = "panelLoginForm";
            panelLoginForm.Size = new Size(500, 370);
            panelLoginForm.TabIndex = 0;
            // 
            // panelPaymentList
            // 
            panelPaymentList.BackColor = Color.White;
            panelPaymentList.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            panelPaymentList.Location = new Point(12, 54);
            panelPaymentList.Name = "panelPaymentList";
            panelPaymentList.Size = new Size(476, 244);
            panelPaymentList.TabIndex = 9;
            panelPaymentList.Text = "Pay Now";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(176, 215, 181);
            btnPay.BorderColor = Color.FromArgb(220, 223, 230);
            btnPay.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnPay.DangerColor = Color.FromArgb(245, 108, 108);
            btnPay.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPay.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnPay.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPay.InfoColor = Color.FromArgb(144, 147, 153);
            btnPay.Location = new Point(366, 304);
            btnPay.Name = "btnPay";
            btnPay.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnPay.Size = new Size(90, 34);
            btnPay.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay Now";
            btnPay.TextColor = Color.White;
            btnPay.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnCancle
            // 
            btnCancle.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancle.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancle.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancle.Location = new Point(254, 304);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(90, 34);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 7;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // panelHeaderLogin
            // 
            panelHeaderLogin.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderLogin.Controls.Add(btnClose);
            panelHeaderLogin.Controls.Add(lbNameLogin);
            panelHeaderLogin.Dock = DockStyle.Top;
            panelHeaderLogin.Location = new Point(0, 0);
            panelHeaderLogin.Name = "panelHeaderLogin";
            panelHeaderLogin.Size = new Size(500, 48);
            panelHeaderLogin.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.can_t1;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(475, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lbNameLogin
            // 
            lbNameLogin.AutoSize = true;
            lbNameLogin.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameLogin.ForeColor = Color.White;
            lbNameLogin.Location = new Point(154, 13);
            lbNameLogin.Name = "lbNameLogin";
            lbNameLogin.Size = new Size(211, 23);
            lbNameLogin.TabIndex = 1;
            lbNameLogin.Text = "Select Payment Method";
            // 
            // PopUp_PaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 370);
            Controls.Add(panelLoginForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_PaymentMethod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Form";
            panelLoginForm.ResumeLayout(false);
            panelHeaderLogin.ResumeLayout(false);
            panelHeaderLogin.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelLoginForm;
        private Panel panelHeaderLogin;
        private Label lbNameLogin;
        private ReaLTaiizor.Controls.HopeButton btnPay;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private Button btnClose;
        private FlowLayoutPanel panelPaymentList;
    }
}