using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_ApproveCode
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
        ///  private void InitializeEventHandeler()
        private void InitializeEventHandeler()
        {
            // Code
            txtPassword.Enter += txtboxPassword_MouseEnter;
            txtPassword.Leave += txtboxPassword_MouseLeave;
            
            CustomStyle.AttachDynamicKeyEvent(txtPassword, txtboxCode);
            btnOpenEye.Click += btnOpenEye_Click;

            txtboxCode.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxCode.Leave += CustomStyle.OnMouseLeave_Placeholder;
            CustomStyle.AttachDynamicKeyEvent(txtboxCode, txtPassword);

            btnCloseApproval.Click += btnCloseApproval_Click;
            btnLogin.Click += btnLogin_Click;
            btnCancle.Click += btnCancle_Click;
        }

        /// </summary>
        private void InitializeComponent()
        {
            panelApprovalCodeForm = new Panel();
            btnOpenEye = new Button();
            txtPassword = new TextBox();
            txtboxCode = new TextBox();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            txtboxPasswordMain = new ReaLTaiizor.Controls.CyberTextBox();
            txtboxCodeMain = new ReaLTaiizor.Controls.CyberTextBox();
            lbNamePassword = new Label();
            lbNameCode = new Label();
            panelHeaderApprovalCode = new Panel();
            btnCloseApproval = new Button();
            lbNameApprovalCode = new Label();
            panelApprovalCodeForm.SuspendLayout();
            panelHeaderApprovalCode.SuspendLayout();
            SuspendLayout();
            // 
            // panelApprovalCodeForm
            // 
            panelApprovalCodeForm.BackColor = Color.FromArgb(176, 215, 181);
            panelApprovalCodeForm.Controls.Add(btnOpenEye);
            panelApprovalCodeForm.Controls.Add(txtPassword);
            panelApprovalCodeForm.Controls.Add(txtboxCode);
            panelApprovalCodeForm.Controls.Add(btnLogin);
            panelApprovalCodeForm.Controls.Add(btnCancle);
            panelApprovalCodeForm.Controls.Add(txtboxPasswordMain);
            panelApprovalCodeForm.Controls.Add(txtboxCodeMain);
            panelApprovalCodeForm.Controls.Add(lbNamePassword);
            panelApprovalCodeForm.Controls.Add(lbNameCode);
            panelApprovalCodeForm.Controls.Add(panelHeaderApprovalCode);
            panelApprovalCodeForm.Location = new Point(0, 0);
            panelApprovalCodeForm.Name = "panelApprovalCodeForm";
            panelApprovalCodeForm.Size = new Size(368, 269);
            panelApprovalCodeForm.TabIndex = 1;
            // 
            // btnOpenEye
            // 
            btnOpenEye.BackColor = Color.White;
            btnOpenEye.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenEye.FlatAppearance.BorderSize = 0;
            btnOpenEye.FlatStyle = FlatStyle.Flat;
            btnOpenEye.Font = new Font("Times New Roman", 11.25F);
            btnOpenEye.Location = new Point(312, 142);
            btnOpenEye.Name = "btnOpenEye";
            btnOpenEye.Size = new Size(23, 27);
            btnOpenEye.TabIndex = 21;
            btnOpenEye.Text = "👁";
            btnOpenEye.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(132, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " Password";
            txtPassword.Size = new Size(203, 19);
            txtPassword.TabIndex = 19;
            // 
            // txtboxCode
            // 
            txtboxCode.BackColor = Color.White;
            txtboxCode.BorderStyle = BorderStyle.None;
            txtboxCode.Font = new Font("Times New Roman", 12F);
            txtboxCode.ForeColor = Color.Black;
            txtboxCode.Location = new Point(132, 94);
            txtboxCode.Name = "txtboxCode";
            txtboxCode.PlaceholderText = " Code";
            txtboxCode.Size = new Size(203, 19);
            txtboxCode.TabIndex = 18;
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
            btnLogin.Location = new Point(269, 209);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnLogin.Size = new Size(73, 32);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
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
            btnCancle.Location = new Point(190, 209);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(73, 32);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 7;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // txtboxPasswordMain
            // 
            txtboxPasswordMain.Alpha = 20;
            txtboxPasswordMain.BackColor = Color.Transparent;
            txtboxPasswordMain.Background_WidthPen = 1F;
            txtboxPasswordMain.BackgroundPen = true;
            txtboxPasswordMain.ColorBackground = Color.White;
            txtboxPasswordMain.ColorBackground_Pen = Color.White;
            txtboxPasswordMain.ColorLighting = Color.White;
            txtboxPasswordMain.ColorPen_1 = Color.White;
            txtboxPasswordMain.ColorPen_2 = Color.White;
            txtboxPasswordMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxPasswordMain.Font = new Font("Arial", 8F);
            txtboxPasswordMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxPasswordMain.Lighting = false;
            txtboxPasswordMain.LinearGradientPen = false;
            txtboxPasswordMain.Location = new Point(122, 137);
            txtboxPasswordMain.Name = "txtboxPasswordMain";
            txtboxPasswordMain.PenWidth = 15;
            txtboxPasswordMain.RGB = false;
            txtboxPasswordMain.Rounding = true;
            txtboxPasswordMain.RoundingInt = 40;
            txtboxPasswordMain.Size = new Size(221, 35);
            txtboxPasswordMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxPasswordMain.TabIndex = 6;
            txtboxPasswordMain.Tag = "Cyber";
            txtboxPasswordMain.TextButton = "";
            txtboxPasswordMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxPasswordMain.Timer_RGB = 300;
            // 
            // txtboxCodeMain
            // 
            txtboxCodeMain.Alpha = 20;
            txtboxCodeMain.BackColor = Color.Transparent;
            txtboxCodeMain.Background_WidthPen = 1F;
            txtboxCodeMain.BackgroundPen = true;
            txtboxCodeMain.ColorBackground = Color.White;
            txtboxCodeMain.ColorBackground_Pen = Color.White;
            txtboxCodeMain.ColorLighting = Color.White;
            txtboxCodeMain.ColorPen_1 = Color.White;
            txtboxCodeMain.ColorPen_2 = Color.White;
            txtboxCodeMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxCodeMain.Font = new Font("Arial", 8F);
            txtboxCodeMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxCodeMain.Lighting = false;
            txtboxCodeMain.LinearGradientPen = false;
            txtboxCodeMain.Location = new Point(122, 85);
            txtboxCodeMain.Name = "txtboxCodeMain";
            txtboxCodeMain.PenWidth = 15;
            txtboxCodeMain.RGB = false;
            txtboxCodeMain.Rounding = true;
            txtboxCodeMain.RoundingInt = 40;
            txtboxCodeMain.Size = new Size(221, 35);
            txtboxCodeMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxCodeMain.TabIndex = 5;
            txtboxCodeMain.Tag = "Cyber";
            txtboxCodeMain.TextButton = "";
            txtboxCodeMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxCodeMain.Timer_RGB = 300;
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
            // lbNameCode
            // 
            lbNameCode.AutoSize = true;
            lbNameCode.Font = new Font("Times New Roman", 12F);
            lbNameCode.ForeColor = SystemColors.WindowText;
            lbNameCode.Location = new Point(33, 94);
            lbNameCode.Name = "lbNameCode";
            lbNameCode.Size = new Size(43, 19);
            lbNameCode.TabIndex = 1;
            lbNameCode.Text = "Code";
            // 
            // panelHeaderApprovalCode
            // 
            panelHeaderApprovalCode.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderApprovalCode.Controls.Add(btnCloseApproval);
            panelHeaderApprovalCode.Controls.Add(lbNameApprovalCode);
            panelHeaderApprovalCode.Location = new Point(0, 0);
            panelHeaderApprovalCode.Name = "panelHeaderApprovalCode";
            panelHeaderApprovalCode.Size = new Size(368, 48);
            panelHeaderApprovalCode.TabIndex = 0;
            // 
            // btnCloseApproval
            // 
            btnCloseApproval.BackgroundImage = Properties.Resources.can_t1;
            btnCloseApproval.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseApproval.Cursor = Cursors.Hand;
            btnCloseApproval.FlatAppearance.BorderSize = 0;
            btnCloseApproval.FlatStyle = FlatStyle.Flat;
            btnCloseApproval.Location = new Point(345, 8);
            btnCloseApproval.Name = "btnCloseApproval";
            btnCloseApproval.Size = new Size(15, 14);
            btnCloseApproval.TabIndex = 2;
            btnCloseApproval.UseVisualStyleBackColor = true;
            // 
            // lbNameApprovalCode
            // 
            lbNameApprovalCode.AutoSize = true;
            lbNameApprovalCode.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameApprovalCode.ForeColor = Color.White;
            lbNameApprovalCode.Location = new Point(109, 13);
            lbNameApprovalCode.Name = "lbNameApprovalCode";
            lbNameApprovalCode.Size = new Size(133, 22);
            lbNameApprovalCode.TabIndex = 1;
            lbNameApprovalCode.Text = "Approval Code";
            // 
            // PopUp_ApproveCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 269);
            Controls.Add(panelApprovalCodeForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_ApproveCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_ApproveCode";
            Load += InitailizeLoad_Component;
            panelApprovalCodeForm.ResumeLayout(false);
            panelApprovalCodeForm.PerformLayout();
            panelHeaderApprovalCode.ResumeLayout(false);
            panelHeaderApprovalCode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /*private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "")
            {
                txtboxPassword.Text = txtboxPassword.Tag!.ToString();
                txtboxPassword.ForeColor = Color.DarkGray;
                txtboxPassword.UseSystemPasswordChar = _isShowPasswordApprove;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar = _isShowPasswordApprove;
                txtboxPassword.Text = txtboxPassword.Text;
                txtboxPassword.ForeColor = Color.Black;
            }
        }

        private void txtboxPassword_Enter(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == txtboxPassword.Tag!.ToString())
            {
                txtboxPassword.Text = "";
                txtboxPassword.ForeColor = Color.Black;
                txtboxPassword.UseSystemPasswordChar = !_isShowPasswordApprove;
            }
            else if (txtboxPassword.Text != txtboxPassword.Tag.ToString())
            {
                txtboxPassword.ForeColor = Color.Black;
                var text = txtboxPassword.Text;
                txtboxPassword.Text = text;
            }
        }*/

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


        private Panel panelApprovalCodeForm;
        private TextBox txtPassword;
        private TextBox txtboxCode;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private ReaLTaiizor.Controls.CyberTextBox txtboxPasswordMain;
        private ReaLTaiizor.Controls.CyberTextBox txtboxCodeMain;
        private Label lbNamePassword;
        private Label lbNameCode;
        private Panel panelHeaderApprovalCode;
        private Label lbNameApprovalCode;
        private Button btnOpenEye;
        private Button btnCloseApproval;

        //private bool _isShowPasswordApprove { get; set; } = false;
        private bool _isShowPassword { get; set; } = false;
    }
}