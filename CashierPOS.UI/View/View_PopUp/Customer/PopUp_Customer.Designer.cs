namespace CashierPOS.UI.View.View_PopUp.Customer
{
    partial class PopUp_Customer
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
        private void InitializeComponent()
        {
            panelHeaderPaymentOption = new Panel();
            btnClose = new Button();
            lbNamePaymentOption = new Label();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            txtEarningPoint = new TextBox();
            cyberTextBox3 = new ReaLTaiizor.Controls.CyberTextBox();
            txtEarningAmount = new TextBox();
            btnCreateNewCust = new ReaLTaiizor.Controls.HopeButton();
            label2 = new Label();
            lbNameUserID = new Label();
            txtContact = new TextBox();
            txtContactMain = new ReaLTaiizor.Controls.CyberTextBox();
            txtCode = new TextBox();
            txtCodeMain = new ReaLTaiizor.Controls.CyberTextBox();
            label7 = new Label();
            label4 = new Label();
            panelHeaderPaymentOption.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeaderPaymentOption
            // 
            panelHeaderPaymentOption.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderPaymentOption.Controls.Add(btnClose);
            panelHeaderPaymentOption.Controls.Add(lbNamePaymentOption);
            panelHeaderPaymentOption.Dock = DockStyle.Top;
            panelHeaderPaymentOption.Font = new Font("Times New Roman", 14.25F);
            panelHeaderPaymentOption.Location = new Point(0, 0);
            panelHeaderPaymentOption.Name = "panelHeaderPaymentOption";
            panelHeaderPaymentOption.Size = new Size(525, 48);
            panelHeaderPaymentOption.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.icon_close22;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(496, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 23);
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbNamePaymentOption
            // 
            lbNamePaymentOption.AutoSize = true;
            lbNamePaymentOption.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNamePaymentOption.ForeColor = Color.White;
            lbNamePaymentOption.Location = new Point(194, 13);
            lbNamePaymentOption.Name = "lbNamePaymentOption";
            lbNamePaymentOption.Size = new Size(156, 22);
            lbNamePaymentOption.TabIndex = 1;
            lbNamePaymentOption.Text = "Loyalty Customer";
            // 
            // cyberTextBox2
            // 
            cyberTextBox2.Alpha = 20;
            cyberTextBox2.BackColor = Color.Transparent;
            cyberTextBox2.Background_WidthPen = 1F;
            cyberTextBox2.BackgroundPen = true;
            cyberTextBox2.ColorBackground = Color.White;
            cyberTextBox2.ColorBackground_Pen = Color.White;
            cyberTextBox2.ColorLighting = Color.White;
            cyberTextBox2.ColorPen_1 = Color.White;
            cyberTextBox2.ColorPen_2 = Color.White;
            cyberTextBox2.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox2.Font = new Font("Times New Roman", 8F);
            cyberTextBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox2.Lighting = false;
            cyberTextBox2.LinearGradientPen = false;
            cyberTextBox2.Location = new Point(32, 190);
            cyberTextBox2.Name = "cyberTextBox2";
            cyberTextBox2.PenWidth = 15;
            cyberTextBox2.RGB = false;
            cyberTextBox2.Rounding = true;
            cyberTextBox2.RoundingInt = 40;
            cyberTextBox2.Size = new Size(219, 35);
            cyberTextBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox2.TabIndex = 51;
            cyberTextBox2.Tag = "Cyber";
            cyberTextBox2.TextButton = "";
            cyberTextBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox2.Timer_RGB = 300;
            // 
            // txtEarningPoint
            // 
            txtEarningPoint.BackColor = Color.White;
            txtEarningPoint.BorderStyle = BorderStyle.None;
            txtEarningPoint.Font = new Font("Times New Roman", 11.25F);
            txtEarningPoint.ForeColor = Color.Black;
            txtEarningPoint.Location = new Point(44, 200);
            txtEarningPoint.Name = "txtEarningPoint";
            txtEarningPoint.PlaceholderText = "Total Points earned";
            txtEarningPoint.Size = new Size(200, 18);
            txtEarningPoint.TabIndex = 52;
            txtEarningPoint.Enabled = false;
            // 
            // cyberTextBox3
            // 
            cyberTextBox3.Alpha = 20;
            cyberTextBox3.BackColor = Color.Transparent;
            cyberTextBox3.Background_WidthPen = 1F;
            cyberTextBox3.BackgroundPen = true;
            cyberTextBox3.ColorBackground = Color.White;
            cyberTextBox3.ColorBackground_Pen = Color.White;
            cyberTextBox3.ColorLighting = Color.White;
            cyberTextBox3.ColorPen_1 = Color.White;
            cyberTextBox3.ColorPen_2 = Color.White;
            cyberTextBox3.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox3.Font = new Font("Times New Roman", 8F);
            cyberTextBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox3.Lighting = false;
            cyberTextBox3.LinearGradientPen = false;
            cyberTextBox3.Location = new Point(269, 190);
            cyberTextBox3.Name = "cyberTextBox3";
            cyberTextBox3.PenWidth = 15;
            cyberTextBox3.RGB = false;
            cyberTextBox3.Rounding = true;
            cyberTextBox3.RoundingInt = 40;
            cyberTextBox3.Size = new Size(220, 35);
            cyberTextBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox3.TabIndex = 51;
            cyberTextBox3.Tag = "Cyber";
            cyberTextBox3.TextButton = "";
            cyberTextBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox3.Timer_RGB = 300;
            // 
            // txtEarningAmount
            // 
            txtEarningAmount.BackColor = Color.White;
            txtEarningAmount.BorderStyle = BorderStyle.None;
            txtEarningAmount.Font = new Font("Times New Roman", 11.25F);
            txtEarningAmount.ForeColor = Color.Black;
            txtEarningAmount.Location = new Point(280, 200);
            txtEarningAmount.Name = "txtEarningAmount";
            txtEarningAmount.PlaceholderText = "Total amount earned";
            txtEarningAmount.Size = new Size(200, 18);
            txtEarningAmount.TabIndex = 52;
            txtEarningAmount.Enabled = false;
            // 
            // btnCreateNewCust
            // 
            btnCreateNewCust.BorderColor = Color.FromArgb(220, 223, 230);
            btnCreateNewCust.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCreateNewCust.DangerColor = Color.FromArgb(245, 108, 108);
            btnCreateNewCust.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCreateNewCust.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCreateNewCust.ForeColor = SystemColors.WindowText;
            btnCreateNewCust.HoverTextColor = Color.White;
            btnCreateNewCust.InfoColor = Color.FromArgb(144, 147, 153);
            btnCreateNewCust.Location = new Point(169, 270);
            btnCreateNewCust.Name = "btnCreateNewCust";
            btnCreateNewCust.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnCreateNewCust.Size = new Size(185, 38);
            btnCreateNewCust.SuccessColor = Color.Lime;
            btnCreateNewCust.TabIndex = 53;
            btnCreateNewCust.Text = "+ Create  New Customer";
            btnCreateNewCust.TextColor = Color.White;
            btnCreateNewCust.WarningColor = Color.FromArgb(230, 162, 60);
            btnCreateNewCust.Click += btnCreateNewCust_Click;
            btnCreateNewCust.MouseEnter += BtnCreateNewCust_MouseHover;
            btnCreateNewCust.MouseLeave += BtnCreateNewCust_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(270, 78);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 87;
            label2.Text = "Phone Number";
            // 
            // lbNameUserID
            // 
            lbNameUserID.AutoSize = true;
            lbNameUserID.Font = new Font("Times New Roman", 12F);
            lbNameUserID.ForeColor = Color.Black;
            lbNameUserID.Location = new Point(34, 76);
            lbNameUserID.Name = "lbNameUserID";
            lbNameUserID.Size = new Size(46, 19);
            lbNameUserID.TabIndex = 85;
            lbNameUserID.Text = "Name";
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.White;
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Font = new Font("Times New Roman", 11.25F);
            txtContact.ForeColor = Color.Black;
            txtContact.Location = new Point(280, 110);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Phone Number ";
            txtContact.Size = new Size(200, 18);
            txtContact.TabIndex = 83;
            txtContact.MaxLength = 12;
            txtContact.TextChanged += TxtContact_TextChanged;
            // 
            // txtContactMain
            // 
            txtContactMain.Alpha = 20;
            txtContactMain.BackColor = Color.Transparent;
            txtContactMain.Background_WidthPen = 1F;
            txtContactMain.BackgroundPen = true;
            txtContactMain.ColorBackground = Color.White;
            txtContactMain.ColorBackground_Pen = Color.White;
            txtContactMain.ColorLighting = Color.White;
            txtContactMain.ColorPen_1 = Color.White;
            txtContactMain.ColorPen_2 = Color.White;
            txtContactMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtContactMain.Font = new Font("Times New Roman", 8F);
            txtContactMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtContactMain.Lighting = false;
            txtContactMain.LinearGradientPen = false;
            txtContactMain.Location = new Point(270, 100);
            txtContactMain.Name = "txtContactMain";
            txtContactMain.PenWidth = 15;
            txtContactMain.RGB = false;
            txtContactMain.Rounding = true;
            txtContactMain.RoundingInt = 40;
            txtContactMain.Size = new Size(220, 35);
            txtContactMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtContactMain.TabIndex = 81;
            txtContactMain.Tag = "Cyber";
            txtContactMain.TextButton = "";
            txtContactMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtContactMain.Timer_RGB = 300;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Font = new Font("Times New Roman", 11.25F);
            txtCode.ForeColor = Color.Black;
            txtCode.Location = new Point(44, 110);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Customer Code";
            txtCode.Size = new Size(200, 18);
            txtCode.TabIndex = 84;
            txtCode.MaxLength = 9;
            txtCode.TextChanged += TxtCode_TextChanged;
            // 
            // txtCodeMain
            // 
            txtCodeMain.Alpha = 20;
            txtCodeMain.BackColor = Color.Transparent;
            txtCodeMain.Background_WidthPen = 1F;
            txtCodeMain.BackgroundPen = true;
            txtCodeMain.ColorBackground = Color.White;
            txtCodeMain.ColorBackground_Pen = Color.White;
            txtCodeMain.ColorLighting = Color.White;
            txtCodeMain.ColorPen_1 = Color.White;
            txtCodeMain.ColorPen_2 = Color.White;
            txtCodeMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtCodeMain.Font = new Font("Times New Roman", 8F);
            txtCodeMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtCodeMain.Lighting = false;
            txtCodeMain.LinearGradientPen = false;
            txtCodeMain.Location = new Point(32, 100);
            txtCodeMain.Name = "txtCodeMain";
            txtCodeMain.PenWidth = 15;
            txtCodeMain.RGB = false;
            txtCodeMain.Rounding = true;
            txtCodeMain.RoundingInt = 40;
            txtCodeMain.Size = new Size(220, 35);
            txtCodeMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCodeMain.TabIndex = 82;
            txtCodeMain.Tag = "Cyber";
            txtCodeMain.TextButton = "";
            txtCodeMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCodeMain.Timer_RGB = 300;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(270, 166);
            label7.Name = "label7";
            label7.Size = new Size(105, 19);
            label7.TabIndex = 91;
            label7.Text = "Earning Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(34, 166);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 89;
            label4.Text = "Earning Point";
            // 
            // PopUp_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 215, 181);
            ClientSize = new Size(525, 350);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbNameUserID);
            Controls.Add(txtContact);
            Controls.Add(txtContactMain);
            Controls.Add(txtCode);
            Controls.Add(txtCodeMain);
            Controls.Add(btnCreateNewCust);
            Controls.Add(txtEarningAmount);
            Controls.Add(cyberTextBox3);
            Controls.Add(txtEarningPoint);
            Controls.Add(cyberTextBox2);
            Controls.Add(panelHeaderPaymentOption);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Customer";
            panelHeaderPaymentOption.ResumeLayout(false);
            panelHeaderPaymentOption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Style when hover button
        private void BtnCreateNewCust_MouseLeave(object sender, EventArgs e)
        {
            btnCreateNewCust.Size = new Size(185, 38);
            btnCreateNewCust.PrimaryColor = Color.FromArgb(47, 155, 70);
        }

        private void BtnCreateNewCust_MouseHover(object sender, EventArgs e)
        {
            btnCreateNewCust.Size = new Size(200, 41);
            btnCreateNewCust.PrimaryColor = Color.FromArgb(103, 194, 58);
        }
        #endregion
        #endregion

        private Panel panelHeaderPaymentOption;
        private Label lbNamePaymentOption;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
        private TextBox txtEarningPoint;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox3;
        private TextBox txtEarningAmount;
        private ReaLTaiizor.Controls.HopeButton btnCreateNewCust;
        private Button btnClose;
        private Label label2;
        private Label lbNameUserID;
        private TextBox txtContact;
        private ReaLTaiizor.Controls.CyberTextBox txtContactMain;
        private TextBox txtCode;
        private ReaLTaiizor.Controls.CyberTextBox txtCodeMain;
        private Label label7;
        private Label label4;
    }
}