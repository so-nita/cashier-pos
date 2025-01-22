namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_Logout
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
        /// </summary>
        private void InitializeDataComponent()
        {
            btnCancel.Click += btnCancel_Click;
        }
        private void InitializeComponent()
        {
            panelLogoutForm = new Panel();
            lbNameAreYouSure = new Label();
            btnLogout = new ReaLTaiizor.Controls.HopeButton();
            btnCancel = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderLogout = new Panel();
            btnCloseLogout = new Button();
            panelLogoutForm.SuspendLayout();
            panelHeaderLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogoutForm
            // 
            panelLogoutForm.BackColor = Color.FromArgb(176, 215, 181);
            panelLogoutForm.Controls.Add(lbNameAreYouSure);
            panelLogoutForm.Controls.Add(btnLogout);
            panelLogoutForm.Controls.Add(btnCancel);
            panelLogoutForm.Controls.Add(panelHeaderLogout);
            panelLogoutForm.Location = new Point(0, 0);
            panelLogoutForm.Name = "panelLogoutForm";
            panelLogoutForm.Size = new Size(368, 230);
            panelLogoutForm.TabIndex = 1;
            // 
            // lbNameAreYouSure
            // 
            lbNameAreYouSure.AutoSize = true;
            lbNameAreYouSure.Font = new Font("Times New Roman", 14.25F);
            lbNameAreYouSure.ForeColor = SystemColors.WindowText;
            lbNameAreYouSure.Location = new Point(89, 104);
            lbNameAreYouSure.Name = "lbNameAreYouSure";
            lbNameAreYouSure.Size = new Size(197, 21);
            lbNameAreYouSure.TabIndex = 9;
            lbNameAreYouSure.Text = "Are You Sure to Logout?";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(176, 215, 181);
            btnLogout.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogout.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogout.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogout.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLogout.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogout.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogout.Location = new Point(269, 171);
            btnLogout.Name = "btnLogout";
            btnLogout.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnLogout.Size = new Size(73, 32);
            btnLogout.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Yes";
            btnLogout.TextColor = Color.White;
            btnLogout.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancel.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancel.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancel.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancel.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancel.Location = new Point(190, 171);
            btnCancel.Name = "btnCancel";
            btnCancel.PrimaryColor = Color.Red;
            btnCancel.Size = new Size(73, 32);
            btnCancel.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "No";
            btnCancel.TextColor = Color.White;
            btnCancel.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // panelHeaderLogout
            // 
            panelHeaderLogout.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderLogout.Controls.Add(btnCloseLogout);
            panelHeaderLogout.Location = new Point(0, 0);
            panelHeaderLogout.Name = "panelHeaderLogout";
            panelHeaderLogout.Size = new Size(368, 48);
            panelHeaderLogout.TabIndex = 0;
            // 
            // btnCloseLogout
            // 
            btnCloseLogout.BackgroundImage = Properties.Resources.can_t1;
            btnCloseLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseLogout.FlatAppearance.BorderSize = 0;
            btnCloseLogout.FlatStyle = FlatStyle.Flat;
            btnCloseLogout.Location = new Point(346, 8);
            btnCloseLogout.Name = "btnCloseLogout";
            btnCloseLogout.Size = new Size(15, 14);
            btnCloseLogout.TabIndex = 6;
            btnCloseLogout.UseVisualStyleBackColor = true;
            btnCloseLogout.Click += btnCloseLogout_Click;
            // 
            // PopUp_Logout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 230);
            Controls.Add(panelLogoutForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_Logout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Logout";
            panelLogoutForm.ResumeLayout(false);
            panelLogoutForm.PerformLayout();
            panelHeaderLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogoutForm;
        private ReaLTaiizor.Controls.HopeButton btnLogout;
        private ReaLTaiizor.Controls.HopeButton btnCancel;
        private Panel panelHeaderLogout;
        private Label lbNameAreYouSure;
        private Button btnCloseLogout;
    }
}