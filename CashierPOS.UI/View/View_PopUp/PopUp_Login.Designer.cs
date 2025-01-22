using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_LoginForm
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
            txtUserID.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtUserID.Leave += CustomStyle.OnMouseLeave_Placeholder;
            CustomStyle.AttachDynamicKeyEvent(txtUserID, txtPassword);
            //txtboxUserID.KeyDown += txtboxUserID_PressEnter;

            txtPassword.Enter += txtboxPassword_MouseEnter;
            txtPassword.Leave += txtboxPassword_MouseLeave;
            CustomStyle.AttachDynamicKeyEvent(txtPassword, txtUserID);

            //txtboxPassword.KeyUp += TxtboxPassword_PreviewKeyDown;
        }

        /*private void TxtboxPassword_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtboxUserID.Focus();
                e.Handled = true; // Prevent the Enter key from being processed further
            }
        }
        private void txtboxUserID_PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                // Move focus to txt2 when Enter key is pressed in txt1
                txtboxPassword.Focus();
                e.Handled = true; // Prevent the Enter key from being processed further
            }
        }
        //Button Close Form Login POP UP
        private void btnClose_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }*/

        /// </summary>
        private void InitializeComponent()
        {
            panelLoginForm = new Panel();
            btnOpenEye = new Button();
            txtPassword = new TextBox();
            txtUserID = new TextBox();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            txtPasswordMain = new ReaLTaiizor.Controls.CyberTextBox();
            txtUserIDMain = new ReaLTaiizor.Controls.CyberTextBox();
            lbNamePassword = new Label();
            lbNameUserID = new Label();
            panelHeaderLogin = new Panel();
            btnCloseLogin = new Button();
            lbNameLogin = new Label();
            panelLoginForm.SuspendLayout();
            panelHeaderLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLoginForm
            // 
            panelLoginForm.BackColor = Color.FromArgb(176, 215, 181);
            panelLoginForm.Controls.Add(btnOpenEye);
            panelLoginForm.Controls.Add(txtPassword);
            panelLoginForm.Controls.Add(txtUserID);
            panelLoginForm.Controls.Add(btnLogin);
            panelLoginForm.Controls.Add(btnCancle);
            panelLoginForm.Controls.Add(txtPasswordMain);
            panelLoginForm.Controls.Add(txtUserIDMain);
            panelLoginForm.Controls.Add(lbNamePassword);
            panelLoginForm.Controls.Add(lbNameUserID);
            panelLoginForm.Controls.Add(panelHeaderLogin);
            panelLoginForm.Location = new Point(0, 0);
            panelLoginForm.Name = "panelLoginForm";
            panelLoginForm.Size = new Size(368, 269);
            panelLoginForm.TabIndex = 0;
            // 
            // btnOpenEye
            // 
            btnOpenEye.BackColor = Color.White;
            btnOpenEye.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenEye.FlatAppearance.BorderSize = 0;
            btnOpenEye.FlatStyle = FlatStyle.Flat;
            btnOpenEye.Font = new Font("Times New Roman", 11.25F);
            btnOpenEye.Location = new Point(312, 144);
            btnOpenEye.Name = "btnOpenEye";
            btnOpenEye.Size = new Size(20, 25);
            btnOpenEye.TabIndex = 20;
            btnOpenEye.Text = "👁";
            btnOpenEye.UseVisualStyleBackColor = false;
            btnOpenEye.Click += btnOpenEye_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Times New Roman", 11.25F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(132, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(203, 18);
            txtPassword.TabIndex = 19;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.White;
            txtUserID.BorderStyle = BorderStyle.None;
            txtUserID.Font = new Font("Times New Roman", 11.25F);
            txtUserID.ForeColor = Color.Black;
            txtUserID.Location = new Point(132, 95);
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "User ID";
            txtUserID.Size = new Size(203, 18);
            txtUserID.TabIndex = 18;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(176, 215, 181);
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(268, 209);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnLogin.Size = new Size(73, 32);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
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
            btnCancle.Location = new Point(179, 209);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(73, 32);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 7;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancle.Click += btnCancle_Click;
            // 
            // txtPasswordMain
            // 
            txtPasswordMain.Alpha = 20;
            txtPasswordMain.BackColor = Color.Transparent;
            txtPasswordMain.Background_WidthPen = 1F;
            txtPasswordMain.BackgroundPen = true;
            txtPasswordMain.ColorBackground = Color.White;
            txtPasswordMain.ColorBackground_Pen = Color.White;
            txtPasswordMain.ColorLighting = Color.White;
            txtPasswordMain.ColorPen_1 = Color.White;
            txtPasswordMain.ColorPen_2 = Color.White;
            txtPasswordMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPasswordMain.Font = new Font("Arial", 8F);
            txtPasswordMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtPasswordMain.Lighting = false;
            txtPasswordMain.LinearGradientPen = false;
            txtPasswordMain.Location = new Point(122, 137);
            txtPasswordMain.Name = "txtPasswordMain";
            txtPasswordMain.PenWidth = 15;
            txtPasswordMain.RGB = false;
            txtPasswordMain.Rounding = true;
            txtPasswordMain.RoundingInt = 40;
            txtPasswordMain.Size = new Size(221, 35);
            txtPasswordMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPasswordMain.TabIndex = 6;
            txtPasswordMain.Tag = "Cyber";
            txtPasswordMain.TextButton = "";
            txtPasswordMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPasswordMain.Timer_RGB = 300;
            // 
            // txtUserIDMain
            // 
            txtUserIDMain.Alpha = 20;
            txtUserIDMain.BackColor = Color.Transparent;
            txtUserIDMain.Background_WidthPen = 1F;
            txtUserIDMain.BackgroundPen = true;
            txtUserIDMain.ColorBackground = Color.White;
            txtUserIDMain.ColorBackground_Pen = Color.White;
            txtUserIDMain.ColorLighting = Color.White;
            txtUserIDMain.ColorPen_1 = Color.White;
            txtUserIDMain.ColorPen_2 = Color.White;
            txtUserIDMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtUserIDMain.Font = new Font("Arial", 8F);
            txtUserIDMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtUserIDMain.Lighting = false;
            txtUserIDMain.LinearGradientPen = false;
            txtUserIDMain.Location = new Point(122, 85);
            txtUserIDMain.Name = "txtUserIDMain";
            txtUserIDMain.PenWidth = 15;
            txtUserIDMain.RGB = false;
            txtUserIDMain.Rounding = true;
            txtUserIDMain.RoundingInt = 40;
            txtUserIDMain.Size = new Size(221, 35);
            txtUserIDMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtUserIDMain.TabIndex = 5;
            txtUserIDMain.Tag = "Cyber";
            txtUserIDMain.TextButton = "";
            txtUserIDMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtUserIDMain.Timer_RGB = 300;
            // 
            // lbNamePassword
            // 
            lbNamePassword.AutoSize = true;
            lbNamePassword.Font = new Font("Times New Roman", 12F);
            lbNamePassword.ForeColor = SystemColors.WindowText;
            lbNamePassword.Location = new Point(33, 145);
            lbNamePassword.Name = "lbNamePassword";
            lbNamePassword.Size = new Size(69, 19);
            lbNamePassword.TabIndex = 2;
            lbNamePassword.Text = "Password";
            // 
            // lbNameUserID
            // 
            lbNameUserID.AutoSize = true;
            lbNameUserID.Font = new Font("Times New Roman", 12F);
            lbNameUserID.ForeColor = SystemColors.WindowText;
            lbNameUserID.Location = new Point(33, 94);
            lbNameUserID.Name = "lbNameUserID";
            lbNameUserID.Size = new Size(58, 19);
            lbNameUserID.TabIndex = 1;
            lbNameUserID.Text = "User ID";
            // 
            // panelHeaderLogin
            // 
            panelHeaderLogin.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderLogin.Controls.Add(btnCloseLogin);
            panelHeaderLogin.Controls.Add(lbNameLogin);
            panelHeaderLogin.Location = new Point(0, 0);
            panelHeaderLogin.Name = "panelHeaderLogin";
            panelHeaderLogin.Size = new Size(368, 48);
            panelHeaderLogin.TabIndex = 0;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.BackgroundImage = Properties.Resources.can_t1;
            btnCloseLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseLogin.FlatAppearance.BorderSize = 0;
            btnCloseLogin.FlatStyle = FlatStyle.Flat;
            btnCloseLogin.Location = new Point(344, 7);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(18, 18);
            btnCloseLogin.TabIndex = 3;
            btnCloseLogin.UseVisualStyleBackColor = true;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // lbNameLogin
            // 
            lbNameLogin.AutoSize = true;
            lbNameLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameLogin.ForeColor = Color.White;
            lbNameLogin.Location = new Point(154, 13);
            lbNameLogin.Name = "lbNameLogin";
            lbNameLogin.Size = new Size(57, 22);
            lbNameLogin.TabIndex = 1;
            lbNameLogin.Text = "Login";
            // 
            // PopUp_LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 269);
            Controls.Add(panelLoginForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Form";
            Load += InitailizeLoad_Component;
            panelLoginForm.ResumeLayout(false);
            panelLoginForm.PerformLayout();
            panelHeaderLogin.ResumeLayout(false);
            panelHeaderLogin.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private void txtboxPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                HidePassword();
            }
        }

        private void txtboxPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                //txtboxPassword.Text = "Password";
                HidePassword();
            }
            else
            {
                HidePassword();
            }
        }
        //Button Click Eye
        private void btnOpenEye_Click(object sender, EventArgs e)
        {
            _isShowPassword = !_isShowPassword;
            HidePassword();
        }

        private Panel panelLoginForm;
        private Panel panelHeaderLogin;
        private Label lbNameLogin;
        private Label lbNamePassword;
        private Label lbNameUserID;
        private ReaLTaiizor.Controls.CyberTextBox txtPasswordMain;
        private ReaLTaiizor.Controls.CyberTextBox txtUserIDMain;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private Button btnOpenEye;
        private Button btnCloseLogin;

        private bool _isShowPassword { get; set; } = false;
    }
}