namespace CashierPOS.UI.View.View_PopUp.Customer
{
    partial class PopUp_CreateNewCustomer
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
            btnSave.Click += btnSave_Click;
            btnSave.MouseHover += BtnSave_MouseHover;
            btnSave.MouseLeave += BtnSave_MouseLeave;

            txtContact.MaxLength = 12;
            comboGender.Enter += comboGender_OnEnter;
            comboNationality.Enter += comboNationality_OnEnter;
        }
        private void InitializeComponent()
        {
            panelHeaderPaymentOption = new Panel();
            btnClose = new Button();
            lbNamePaymentOption = new Label();
            panelContent = new Panel();
            comboNationality = new ReaLTaiizor.Controls.DungeonComboBox();
            comboNationalityMain = new ReaLTaiizor.Controls.CyberTextBox();
            comboGender = new ReaLTaiizor.Controls.DungeonComboBox();
            comboGenderMain = new ReaLTaiizor.Controls.CyberTextBox();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            lbNameUserID = new Label();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            txtContact = new TextBox();
            txtContactMain = new ReaLTaiizor.Controls.CyberTextBox();
            txtName = new TextBox();
            txtNameMain = new ReaLTaiizor.Controls.CyberTextBox();
            panelHeaderPaymentOption.SuspendLayout();
            panelContent.SuspendLayout();
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
            panelHeaderPaymentOption.TabIndex = 54;
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
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbNamePaymentOption
            // 
            lbNamePaymentOption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNamePaymentOption.AutoSize = true;
            lbNamePaymentOption.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNamePaymentOption.ForeColor = Color.White;
            lbNamePaymentOption.Location = new Point(177, 11);
            lbNamePaymentOption.Name = "lbNamePaymentOption";
            lbNamePaymentOption.Size = new Size(193, 22);
            lbNamePaymentOption.TabIndex = 1;
            lbNamePaymentOption.Text = "Create New Customer";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(176, 215, 181);
            panelContent.Controls.Add(comboNationality);
            panelContent.Controls.Add(comboNationalityMain);
            panelContent.Controls.Add(comboGender);
            panelContent.Controls.Add(comboGenderMain);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label7);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(lbNameUserID);
            panelContent.Controls.Add(btnSave);
            panelContent.Controls.Add(txtContact);
            panelContent.Controls.Add(txtContactMain);
            panelContent.Controls.Add(txtName);
            panelContent.Controls.Add(txtNameMain);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Font = new Font("Times New Roman", 14.25F);
            panelContent.Location = new Point(0, 48);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(525, 302);
            panelContent.TabIndex = 85;
            // 
            // comboNationality
            // 
            comboNationality.BackColor = Color.White;
            comboNationality.ColorA = Color.FromArgb(47, 155, 70);
            comboNationality.ColorB = Color.FromArgb(47, 155, 70);
            comboNationality.ColorC = Color.FromArgb(242, 241, 240);
            comboNationality.ColorD = Color.White;
            comboNationality.ColorE = Color.White;
            comboNationality.ColorF = Color.White;
            comboNationality.ColorG = Color.FromArgb(119, 119, 118);
            comboNationality.ColorH = Color.FromArgb(224, 222, 220);
            comboNationality.ColorI = Color.FromArgb(250, 249, 249);
            comboNationality.DrawMode = DrawMode.OwnerDrawFixed;
            comboNationality.DropDownHeight = 100;
            comboNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNationality.FlatStyle = FlatStyle.Flat;
            comboNationality.Font = new Font("Times New Roman", 11.25F);
            comboNationality.ForeColor = Color.Black;
            comboNationality.FormattingEnabled = true;
            comboNationality.HoverSelectionColor = Color.Empty;
            comboNationality.IntegralHeight = false;
            comboNationality.ItemHeight = 25;
            comboNationality.Location = new Point(273, 154);
            comboNationality.Name = "comboNationality";
            comboNationality.Size = new Size(220, 31);
            comboNationality.StartIndex = 0;
            comboNationality.TabIndex = 103;
            // 
            // comboNationalityMain
            // 
            comboNationalityMain.Alpha = 20;
            comboNationalityMain.BackColor = Color.Transparent;
            comboNationalityMain.Background_WidthPen = 1F;
            comboNationalityMain.BackgroundPen = true;
            comboNationalityMain.ColorBackground = Color.White;
            comboNationalityMain.ColorBackground_Pen = Color.White;
            comboNationalityMain.ColorLighting = Color.White;
            comboNationalityMain.ColorPen_1 = Color.White;
            comboNationalityMain.ColorPen_2 = Color.White;
            comboNationalityMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            comboNationalityMain.Font = new Font("Times New Roman", 9F);
            comboNationalityMain.ForeColor = Color.FromArgb(245, 245, 245);
            comboNationalityMain.Lighting = false;
            comboNationalityMain.LinearGradientPen = false;
            comboNationalityMain.Location = new Point(270, 150);
            comboNationalityMain.Name = "comboNationalityMain";
            comboNationalityMain.PenWidth = 15;
            comboNationalityMain.RGB = false;
            comboNationalityMain.Rounding = true;
            comboNationalityMain.RoundingInt = 40;
            comboNationalityMain.Size = new Size(225, 37);
            comboNationalityMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            comboNationalityMain.TabIndex = 102;
            comboNationalityMain.Tag = "Cyber";
            comboNationalityMain.TextButton = "";
            comboNationalityMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            comboNationalityMain.Timer_RGB = 300;
            // 
            // comboGender
            // 
            comboGender.BackColor = Color.White;
            comboGender.ColorA = Color.FromArgb(47, 155, 70);
            comboGender.ColorB = Color.FromArgb(47, 155, 70);
            comboGender.ColorC = Color.FromArgb(242, 241, 240);
            comboGender.ColorD = Color.White;
            comboGender.ColorE = Color.White;
            comboGender.ColorF = Color.White;
            comboGender.ColorG = Color.FromArgb(119, 119, 118);
            comboGender.ColorH = Color.FromArgb(224, 222, 220);
            comboGender.ColorI = Color.FromArgb(250, 249, 249);
            comboGender.DrawMode = DrawMode.OwnerDrawFixed;
            comboGender.DropDownHeight = 100;
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.FlatStyle = FlatStyle.Flat;
            comboGender.Font = new Font("Times New Roman", 11.25F);
            comboGender.ForeColor = Color.Black;
            comboGender.FormattingEnabled = true;
            comboGender.HoverSelectionColor = Color.Empty;
            comboGender.IntegralHeight = false;
            comboGender.ItemHeight = 25;
            comboGender.Location = new Point(34, 154);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(218, 31);
            comboGender.StartIndex = 0;
            comboGender.TabIndex = 101;
            // 
            // comboGenderMain
            // 
            comboGenderMain.Alpha = 20;
            comboGenderMain.BackColor = Color.Transparent;
            comboGenderMain.Background_WidthPen = 1F;
            comboGenderMain.BackgroundPen = true;
            comboGenderMain.ColorBackground = Color.White;
            comboGenderMain.ColorBackground_Pen = Color.White;
            comboGenderMain.ColorLighting = Color.White;
            comboGenderMain.ColorPen_1 = Color.White;
            comboGenderMain.ColorPen_2 = Color.White;
            comboGenderMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            comboGenderMain.Font = new Font("Times New Roman", 9F);
            comboGenderMain.ForeColor = Color.FromArgb(245, 245, 245);
            comboGenderMain.Lighting = false;
            comboGenderMain.LinearGradientPen = false;
            comboGenderMain.Location = new Point(30, 150);
            comboGenderMain.Name = "comboGenderMain";
            comboGenderMain.PenWidth = 15;
            comboGenderMain.RGB = false;
            comboGenderMain.Rounding = true;
            comboGenderMain.RoundingInt = 40;
            comboGenderMain.Size = new Size(225, 37);
            comboGenderMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            comboGenderMain.TabIndex = 100;
            comboGenderMain.Tag = "Cyber";
            comboGenderMain.TextButton = "";
            comboGenderMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            comboGenderMain.Timer_RGB = 300;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(341, 123);
            label6.Name = "label6";
            label6.Size = new Size(17, 19);
            label6.TabIndex = 99;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(270, 126);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 98;
            label7.Text = "Nationality";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(84, 123);
            label3.Name = "label3";
            label3.Size = new Size(17, 19);
            label3.TabIndex = 97;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(34, 126);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 96;
            label4.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(367, 34);
            label1.Name = "label1";
            label1.Size = new Size(17, 19);
            label1.TabIndex = 95;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(271, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 94;
            label2.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(80, 34);
            label5.Name = "label5";
            label5.Size = new Size(17, 19);
            label5.TabIndex = 93;
            label5.Text = "*";
            // 
            // lbNameUserID
            // 
            lbNameUserID.AutoSize = true;
            lbNameUserID.Font = new Font("Times New Roman", 12F);
            lbNameUserID.ForeColor = SystemColors.WindowText;
            lbNameUserID.Location = new Point(35, 36);
            lbNameUserID.Name = "lbNameUserID";
            lbNameUserID.Size = new Size(46, 19);
            lbNameUserID.TabIndex = 92;
            lbNameUserID.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.HoverTextColor = Color.White;
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(358, 230);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnSave.Size = new Size(130, 38);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 89;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.White;
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Font = new Font("Times New Roman", 11.25F);
            txtContact.ForeColor = Color.Black;
            txtContact.Location = new Point(281, 70);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Phone Number *";
            txtContact.Size = new Size(200, 18);
            txtContact.TabIndex = 87;
            txtContact.TextChanged += txtContact_TextChanged;
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
            txtContactMain.Location = new Point(271, 60);
            txtContactMain.Name = "txtContactMain";
            txtContactMain.PenWidth = 15;
            txtContactMain.RGB = false;
            txtContactMain.Rounding = true;
            txtContactMain.RoundingInt = 40;
            txtContactMain.Size = new Size(220, 35);
            txtContactMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtContactMain.TabIndex = 85;
            txtContactMain.Tag = "Cyber";
            txtContactMain.TextButton = "";
            txtContactMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtContactMain.Timer_RGB = 300;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Times New Roman", 11.25F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(45, 70);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name *";
            txtName.Size = new Size(180, 18);
            txtName.TabIndex = 88;
            txtName.Tag = "";
            // 
            // txtNameMain
            // 
            txtNameMain.Alpha = 20;
            txtNameMain.BackColor = Color.Transparent;
            txtNameMain.Background_WidthPen = 1F;
            txtNameMain.BackgroundPen = true;
            txtNameMain.ColorBackground = Color.White;
            txtNameMain.ColorBackground_Pen = Color.White;
            txtNameMain.ColorLighting = Color.White;
            txtNameMain.ColorPen_1 = Color.White;
            txtNameMain.ColorPen_2 = Color.White;
            txtNameMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNameMain.Font = new Font("Times New Roman", 8F);
            txtNameMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtNameMain.Lighting = false;
            txtNameMain.LinearGradientPen = false;
            txtNameMain.Location = new Point(33, 60);
            txtNameMain.Name = "txtNameMain";
            txtNameMain.PenWidth = 15;
            txtNameMain.RGB = false;
            txtNameMain.Rounding = true;
            txtNameMain.RoundingInt = 40;
            txtNameMain.Size = new Size(220, 35);
            txtNameMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNameMain.TabIndex = 86;
            txtNameMain.Tag = "Cyber";
            txtNameMain.TextButton = "";
            txtNameMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNameMain.Timer_RGB = 300;
            // 
            // PopUp_CreateNewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 350);
            Controls.Add(panelContent);
            Controls.Add(panelHeaderPaymentOption);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_CreateNewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_CreateNewCustomer";
            panelHeaderPaymentOption.ResumeLayout(false);
            panelHeaderPaymentOption.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Size = new Size(130, 38);
            btnSave.PrimaryColor = Color.FromArgb(47, 155, 70);
        }

        private void BtnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.Size = new Size(135, 41);
            btnSave.PrimaryColor = Color.FromArgb(103, 194, 58);
        }

        #endregion

        private Panel panelHeaderPaymentOption;
        private Label lbNamePaymentOption;
        private Button btnClose;
        private Panel panelContent;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label lbNameUserID;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private TextBox txtContact;
        private ReaLTaiizor.Controls.CyberTextBox txtContactMain;
        private TextBox txtName;
        private ReaLTaiizor.Controls.CyberTextBox txtNameMain;
        private ReaLTaiizor.Controls.DungeonComboBox comboGender;
        private ReaLTaiizor.Controls.CyberTextBox comboGenderMain;
        private ReaLTaiizor.Controls.DungeonComboBox comboNationality;
        private ReaLTaiizor.Controls.CyberTextBox comboNationalityMain;
    }
}