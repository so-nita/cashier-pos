using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.Testing
{
    partial class PopUp_Discount
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
        private void InitializeEventHandeler()
        {
            //this.ActiveControl = txtboxDiscount;
            txtboxDiscount.KeyPress += CustomStyle.ValidationNumberOnly;
            txtboxDiscount.GotFocus += TextBoxSelected;
        }
        
        private void Enablebtn_Percentage(bool action)
        {
            ActiveControl = txtboxDiscount;
            btn10.Enabled = action;
            btn20.Enabled = action;
            btn30.Enabled = action;
            btn50.Enabled = action;
        }

        private void InitializeComponent()
        {
            lbNamePaymentOption = new Label();
            panelHeaderPaymentOption = new Panel();
            btnClose = new Button();
            txtboxDiscount = new TextBox();
            txtboxMainEarning = new ReaLTaiizor.Controls.CyberTextBox();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            panelAll_number = new Panel();
            btnNum9 = new ReaLTaiizor.Controls.HopeButton();
            btnNum0 = new ReaLTaiizor.Controls.HopeButton();
            btnNum8 = new ReaLTaiizor.Controls.HopeButton();
            btnNum7 = new ReaLTaiizor.Controls.HopeButton();
            btnNum6 = new ReaLTaiizor.Controls.HopeButton();
            btnNumPoint = new ReaLTaiizor.Controls.HopeButton();
            btnNum5 = new ReaLTaiizor.Controls.HopeButton();
            btnNum4 = new ReaLTaiizor.Controls.HopeButton();
            btn30 = new ReaLTaiizor.Controls.HopeButton();
            btnNum3 = new ReaLTaiizor.Controls.HopeButton();
            btn50 = new ReaLTaiizor.Controls.HopeButton();
            btnDel = new ReaLTaiizor.Controls.HopeButton();
            btn20 = new ReaLTaiizor.Controls.HopeButton();
            btnNum2 = new ReaLTaiizor.Controls.HopeButton();
            btn10 = new ReaLTaiizor.Controls.HopeButton();
            btnNum1 = new ReaLTaiizor.Controls.HopeButton();
            btnDiscountType = new ReaLTaiizor.Controls.CyberSwitch();
            label1 = new Label();
            label2 = new Label();
            panelHeaderPaymentOption.SuspendLayout();
            panelAll_number.SuspendLayout();
            SuspendLayout();
            // 
            // lbNamePaymentOption
            // 
            lbNamePaymentOption.AutoSize = true;
            lbNamePaymentOption.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNamePaymentOption.ForeColor = Color.White;
            lbNamePaymentOption.Location = new Point(200, 11);
            lbNamePaymentOption.Name = "lbNamePaymentOption";
            lbNamePaymentOption.Size = new Size(82, 22);
            lbNamePaymentOption.TabIndex = 1;
            lbNamePaymentOption.Text = "Discount";
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
            panelHeaderPaymentOption.Size = new Size(450, 48);
            panelHeaderPaymentOption.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.icon_close22;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(421, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 23);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtboxDiscount
            // 
            txtboxDiscount.BackColor = Color.White;
            txtboxDiscount.BorderStyle = BorderStyle.None;
            txtboxDiscount.Font = new Font("Times New Roman", 11.25F);
            txtboxDiscount.ForeColor = Color.Black;
            txtboxDiscount.Location = new Point(307, 69);
            txtboxDiscount.Name = "txtboxDiscount";
            txtboxDiscount.PlaceholderText = "0.00";
            txtboxDiscount.Size = new Size(70, 18);
            txtboxDiscount.TabIndex = 50;
            txtboxDiscount.TextAlign = HorizontalAlignment.Center;
            txtboxDiscount.TextChanged += txtboxDiscount_TextChanged;
            //txtboxDiscount.TextChanged += txtTotalCashUSD_TextChanged;
            // 
            // txtboxMainEarning
            // 
            txtboxMainEarning.Alpha = 20;
            txtboxMainEarning.BackColor = Color.Transparent;
            txtboxMainEarning.Background_WidthPen = 1F;
            txtboxMainEarning.BackgroundPen = true;
            txtboxMainEarning.ColorBackground = Color.White;
            txtboxMainEarning.ColorBackground_Pen = Color.White;
            txtboxMainEarning.ColorLighting = Color.White;
            txtboxMainEarning.ColorPen_1 = Color.White;
            txtboxMainEarning.ColorPen_2 = Color.White;
            txtboxMainEarning.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainEarning.Font = new Font("Times New Roman", 8F);
            txtboxMainEarning.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainEarning.Lighting = false;
            txtboxMainEarning.LinearGradientPen = false;
            txtboxMainEarning.Location = new Point(292, 60);
            txtboxMainEarning.Name = "txtboxMainEarning";
            txtboxMainEarning.PenWidth = 15;
            txtboxMainEarning.RGB = false;
            txtboxMainEarning.Rounding = true;
            txtboxMainEarning.RoundingInt = 40;
            txtboxMainEarning.Size = new Size(95, 35);
            txtboxMainEarning.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainEarning.TabIndex = 49;
            txtboxMainEarning.Tag = "Cyber";
            txtboxMainEarning.TextButton = "";
            txtboxMainEarning.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainEarning.Timer_RGB = 300;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(176, 215, 181);
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.WindowText;
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(295, 384);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.DeepSkyBlue;
            btnSave.Size = new Size(92, 36);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 51;
            btnSave.Text = "Done";
            btnSave.TextColor = Color.Black;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // panelAll_number
            // 
            panelAll_number.Controls.Add(btnNum9);
            panelAll_number.Controls.Add(btnNum0);
            panelAll_number.Controls.Add(btnNum8);
            panelAll_number.Controls.Add(btnNum7);
            panelAll_number.Controls.Add(btnNum6);
            panelAll_number.Controls.Add(btnNumPoint);
            panelAll_number.Controls.Add(btnNum5);
            panelAll_number.Controls.Add(btnNum4);
            panelAll_number.Controls.Add(btn30);
            panelAll_number.Controls.Add(btnNum3);
            panelAll_number.Controls.Add(btn50);
            panelAll_number.Controls.Add(btnDel);
            panelAll_number.Controls.Add(btn20);
            panelAll_number.Controls.Add(btnNum2);
            panelAll_number.Controls.Add(btn10);
            panelAll_number.Controls.Add(btnNum1);
            panelAll_number.Location = new Point(43, 111);
            panelAll_number.Name = "panelAll_number";
            panelAll_number.Size = new Size(367, 251);
            panelAll_number.TabIndex = 52;
            // 
            // btnNum9
            // 
            btnNum9.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum9.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum9.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum9.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum9.ForeColor = SystemColors.WindowText;
            btnNum9.HoverTextColor = Color.DodgerBlue;
            btnNum9.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum9.Location = new Point(189, 198);
            btnNum9.Name = "btnNum9";
            btnNum9.PrimaryColor = Color.White;
            btnNum9.Size = new Size(70, 50);
            btnNum9.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum9.TabIndex = 60;
            btnNum9.Tag = "";
            btnNum9.Text = "9";
            btnNum9.TextColor = Color.Black;
            btnNum9.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum9.Click += InputNumber;
            // 
            // btnNum0
            // 
            btnNum0.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum0.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum0.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum0.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum0.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum0.ForeColor = SystemColors.WindowText;
            btnNum0.HoverTextColor = Color.DodgerBlue;
            btnNum0.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum0.Location = new Point(274, 198);
            btnNum0.Name = "btnNum0";
            btnNum0.PrimaryColor = Color.White;
            btnNum0.Size = new Size(70, 50);
            btnNum0.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum0.TabIndex = 59;
            btnNum0.Tag = "";
            btnNum0.Text = "0";
            btnNum0.TextColor = Color.Black;
            btnNum0.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum0.Click += InputNumber;
            // 
            // btnNum8
            // 
            btnNum8.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum8.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum8.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum8.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum8.ForeColor = SystemColors.WindowText;
            btnNum8.HoverTextColor = Color.DodgerBlue;
            btnNum8.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum8.Location = new Point(104, 198);
            btnNum8.Name = "btnNum8";
            btnNum8.PrimaryColor = Color.White;
            btnNum8.Size = new Size(70, 50);
            btnNum8.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum8.TabIndex = 58;
            btnNum8.Tag = "";
            btnNum8.Text = "8";
            btnNum8.TextColor = Color.Black;
            btnNum8.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum8.Click += InputNumber;
            // 
            // btnNum7
            // 
            btnNum7.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum7.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum7.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum7.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum7.ForeColor = SystemColors.WindowText;
            btnNum7.HoverTextColor = Color.DodgerBlue;
            btnNum7.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum7.Location = new Point(19, 198);
            btnNum7.Name = "btnNum7";
            btnNum7.PrimaryColor = Color.White;
            btnNum7.Size = new Size(70, 50);
            btnNum7.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum7.TabIndex = 57;
            btnNum7.Tag = "";
            btnNum7.Text = "7";
            btnNum7.TextColor = Color.Black;
            btnNum7.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum7.Click += InputNumber;
            // 
            // btnNum6
            // 
            btnNum6.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum6.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum6.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum6.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum6.ForeColor = SystemColors.WindowText;
            btnNum6.HoverTextColor = Color.DodgerBlue;
            btnNum6.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum6.Location = new Point(189, 133);
            btnNum6.Name = "btnNum6";
            btnNum6.PrimaryColor = Color.White;
            btnNum6.Size = new Size(70, 50);
            btnNum6.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum6.TabIndex = 56;
            btnNum6.Tag = "";
            btnNum6.Text = "6";
            btnNum6.TextColor = Color.Black;
            btnNum6.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum6.Click += InputNumber;
            // 
            // btnNumPoint
            // 
            btnNumPoint.BorderColor = Color.FromArgb(220, 223, 230);
            btnNumPoint.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNumPoint.DangerColor = Color.FromArgb(245, 108, 108);
            btnNumPoint.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNumPoint.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNumPoint.ForeColor = SystemColors.WindowText;
            btnNumPoint.HoverTextColor = Color.DodgerBlue;
            btnNumPoint.InfoColor = Color.FromArgb(144, 147, 153);
            btnNumPoint.Location = new Point(274, 133);
            btnNumPoint.Name = "btnNumPoint";
            btnNumPoint.PrimaryColor = Color.White;
            btnNumPoint.Size = new Size(70, 50);
            btnNumPoint.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNumPoint.TabIndex = 55;
            btnNumPoint.Tag = "";
            btnNumPoint.Text = ".";
            btnNumPoint.TextColor = Color.Black;
            btnNumPoint.WarningColor = Color.FromArgb(230, 162, 60);
            btnNumPoint.Click += InputNumber;
            // 
            // btnNum5
            // 
            btnNum5.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum5.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum5.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum5.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum5.ForeColor = SystemColors.WindowText;
            btnNum5.HoverTextColor = Color.DodgerBlue;
            btnNum5.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum5.Location = new Point(104, 133);
            btnNum5.Name = "btnNum5";
            btnNum5.PrimaryColor = Color.White;
            btnNum5.Size = new Size(70, 50);
            btnNum5.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum5.TabIndex = 54;
            btnNum5.Tag = "";
            btnNum5.Text = "5";
            btnNum5.TextColor = Color.Black;
            btnNum5.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum5.Click += InputNumber;
            // 
            // btnNum4
            // 
            btnNum4.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum4.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum4.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum4.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum4.ForeColor = SystemColors.WindowText;
            btnNum4.HoverTextColor = Color.DodgerBlue;
            btnNum4.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum4.Location = new Point(19, 133);
            btnNum4.Name = "btnNum4";
            btnNum4.PrimaryColor = Color.White;
            btnNum4.Size = new Size(70, 50);
            btnNum4.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum4.TabIndex = 53;
            btnNum4.Tag = "";
            btnNum4.Text = "4";
            btnNum4.TextColor = Color.Black;
            btnNum4.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum4.Click += InputNumber;
            // 
            // btn30
            // 
            btn30.BorderColor = Color.FromArgb(220, 223, 230);
            btn30.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn30.Cursor = Cursors.Hand;
            btn30.DangerColor = Color.FromArgb(245, 108, 108);
            btn30.DefaultColor = Color.FromArgb(255, 255, 255);
            btn30.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btn30.ForeColor = SystemColors.WindowText;
            btn30.HoverTextColor = Color.DodgerBlue;
            btn30.InfoColor = Color.FromArgb(144, 147, 153);
            btn30.Location = new Point(189, 3);
            btn30.Name = "btn30";
            btn30.PrimaryColor = Color.LightSteelBlue;
            btn30.Size = new Size(70, 50);
            btn30.SuccessColor = Color.FromArgb(103, 194, 58);
            btn30.TabIndex = 52;
            btn30.Tag = "";
            btn30.Text = "30%";
            btn30.TextColor = Color.Black;
            btn30.WarningColor = Color.FromArgb(230, 162, 60);
            btn30.Click += InputNumber;
            // 
            // btnNum3
            // 
            btnNum3.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum3.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum3.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum3.ForeColor = SystemColors.WindowText;
            btnNum3.HoverTextColor = Color.DodgerBlue;
            btnNum3.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum3.Location = new Point(189, 68);
            btnNum3.Name = "btnNum3";
            btnNum3.PrimaryColor = Color.White;
            btnNum3.Size = new Size(70, 50);
            btnNum3.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum3.TabIndex = 52;
            btnNum3.Tag = "";
            btnNum3.Text = "3";
            btnNum3.TextColor = Color.Black;
            btnNum3.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum3.Click += InputNumber;
            // 
            // btn50
            // 
            btn50.BorderColor = Color.FromArgb(220, 223, 230);
            btn50.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn50.Cursor = Cursors.Hand;
            btn50.DangerColor = Color.FromArgb(245, 108, 108);
            btn50.DefaultColor = Color.FromArgb(255, 255, 255);
            btn50.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btn50.ForeColor = SystemColors.WindowText;
            btn50.HoverTextColor = Color.DodgerBlue;
            btn50.InfoColor = Color.FromArgb(144, 147, 153);
            btn50.Location = new Point(274, 3);
            btn50.Name = "btn50";
            btn50.PrimaryColor = Color.LightSteelBlue;
            btn50.Size = new Size(70, 50);
            btn50.SuccessColor = Color.FromArgb(103, 194, 58);
            btn50.TabIndex = 51;
            btn50.Text = "50%";
            btn50.TextColor = Color.Black;
            btn50.WarningColor = Color.FromArgb(230, 162, 60);
            btn50.Click += InputNumber;
            // 
            // btnDel
            // 
            btnDel.BorderColor = Color.FromArgb(220, 223, 230);
            btnDel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDel.DangerColor = Color.FromArgb(245, 108, 108);
            btnDel.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnDel.ForeColor = SystemColors.WindowText;
            btnDel.HoverTextColor = Color.DodgerBlue;
            btnDel.InfoColor = Color.FromArgb(144, 147, 153);
            btnDel.Location = new Point(274, 68);
            btnDel.Name = "btnDel";
            btnDel.PrimaryColor = Color.White;
            btnDel.Size = new Size(70, 50);
            btnDel.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDel.TabIndex = 51;
            btnDel.Text = "Del";
            btnDel.TextColor = Color.Black;
            btnDel.WarningColor = Color.FromArgb(230, 162, 60);
            btnDel.Click += btnDel_Click;
            // 
            // btn20
            // 
            btn20.BorderColor = Color.FromArgb(220, 223, 230);
            btn20.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn20.Cursor = Cursors.Hand;
            btn20.DangerColor = Color.FromArgb(245, 108, 108);
            btn20.DefaultColor = Color.FromArgb(255, 255, 255);
            btn20.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btn20.ForeColor = SystemColors.WindowText;
            btn20.HoverTextColor = Color.DodgerBlue;
            btn20.InfoColor = Color.FromArgb(144, 147, 153);
            btn20.Location = new Point(104, 3);
            btn20.Name = "btn20";
            btn20.PrimaryColor = Color.LightSteelBlue;
            btn20.Size = new Size(70, 50);
            btn20.SuccessColor = Color.FromArgb(103, 194, 58);
            btn20.TabIndex = 50;
            btn20.Tag = "";
            btn20.Text = "20%";
            btn20.TextColor = Color.Black;
            btn20.WarningColor = Color.FromArgb(230, 162, 60);
            btn20.Click += InputNumber;
            // 
            // btnNum2
            // 
            btnNum2.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum2.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum2.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum2.ForeColor = SystemColors.WindowText;
            btnNum2.HoverTextColor = Color.DodgerBlue;
            btnNum2.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum2.Location = new Point(104, 68);
            btnNum2.Name = "btnNum2";
            btnNum2.PrimaryColor = Color.White;
            btnNum2.Size = new Size(70, 50);
            btnNum2.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum2.TabIndex = 50;
            btnNum2.Tag = "";
            btnNum2.Text = "2";
            btnNum2.TextColor = Color.Black;
            btnNum2.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum2.Click += InputNumber;
            // 
            // btn10
            // 
            btn10.BorderColor = Color.FromArgb(220, 223, 230);
            btn10.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn10.Cursor = Cursors.Hand;
            btn10.DangerColor = Color.FromArgb(245, 108, 108);
            btn10.DefaultColor = Color.White;
            btn10.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btn10.ForeColor = SystemColors.WindowText;
            btn10.HoverTextColor = Color.DodgerBlue;
            btn10.InfoColor = Color.FromArgb(144, 147, 153);
            btn10.Location = new Point(19, 3);
            btn10.Name = "btn10";
            btn10.PrimaryColor = Color.LightSteelBlue;
            btn10.Size = new Size(70, 50);
            btn10.SuccessColor = Color.FromArgb(103, 194, 58);
            btn10.TabIndex = 49;
            btn10.Tag = "";
            btn10.Text = "10%";
            btn10.TextColor = Color.Black;
            btn10.WarningColor = Color.FromArgb(230, 162, 60);
            btn10.Click += InputNumber;
            // 
            // btnNum1
            // 
            btnNum1.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum1.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum1.DefaultColor = Color.White;
            btnNum1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum1.ForeColor = SystemColors.WindowText;
            btnNum1.HoverTextColor = Color.DodgerBlue;
            btnNum1.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum1.Location = new Point(19, 68);
            btnNum1.Name = "btnNum1";
            btnNum1.PrimaryColor = Color.White;
            btnNum1.Size = new Size(70, 50);
            btnNum1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum1.TabIndex = 49;
            btnNum1.Tag = "";
            btnNum1.Text = "1";
            btnNum1.TextColor = Color.Black;
            btnNum1.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum1.Click += InputNumber;
            // 
            // btnDiscountType
            // 
            btnDiscountType.Alpha = 50;
            btnDiscountType.BackColor = Color.Transparent;
            btnDiscountType.Background = true;
            btnDiscountType.Background_WidthPen = 2F;
            btnDiscountType.BackgroundPen = true;
            btnDiscountType.CausesValidation = false;
            btnDiscountType.Checked = false;
            btnDiscountType.ColorBackground = Color.White;
            btnDiscountType.ColorBackground_1 = Color.White;
            btnDiscountType.ColorBackground_2 = Color.White;
            btnDiscountType.ColorBackground_Pen = Color.White;
            btnDiscountType.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            btnDiscountType.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            btnDiscountType.ColorLighting = Color.FromArgb(29, 200, 238);
            btnDiscountType.ColorPen_1 = Color.FromArgb(29, 200, 238);
            btnDiscountType.ColorPen_2 = Color.FromArgb(29, 200, 238);
            btnDiscountType.ColorValue = Color.FromArgb(29, 200, 238);
            btnDiscountType.Cursor = Cursors.Hand;
            btnDiscountType.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDiscountType.Font = new Font("Arial", 11F);
            btnDiscountType.ForeColor = Color.White;
            btnDiscountType.Lighting = false;
            btnDiscountType.LinearGradient_Background = false;
            btnDiscountType.LinearGradient_Value = false;
            btnDiscountType.LinearGradientPen = false;
            btnDiscountType.Location = new Point(81, 63);
            btnDiscountType.Name = "btnDiscountType";
            btnDiscountType.PenWidth = 10;
            btnDiscountType.RGB = false;
            btnDiscountType.Rounding = true;
            btnDiscountType.RoundingInt = 90;
            btnDiscountType.Size = new Size(57, 32);
            btnDiscountType.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDiscountType.TabIndex = 53;
            btnDiscountType.Tag = "Cyber";
            btnDiscountType.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDiscountType.Timer_RGB = 300;
            btnDiscountType.CheckedChanged += Switch_TypeDiscount_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 69);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 54;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(144, 69);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 54;
            label2.Text = "$";
            // 
            // PopUp_Discount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 213);
            ClientSize = new Size(450, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDiscountType);
            Controls.Add(panelAll_number);
            Controls.Add(btnSave);
            Controls.Add(txtboxDiscount);
            Controls.Add(txtboxMainEarning);
            Controls.Add(panelHeaderPaymentOption);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_Discount";
            StartPosition = FormStartPosition.CenterScreen;
            panelHeaderPaymentOption.ResumeLayout(false);
            panelHeaderPaymentOption.PerformLayout();
            panelAll_number.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNamePaymentOption;
        private Panel panelHeaderPaymentOption;
        private TextBox txtboxDiscount;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainEarning;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private Panel panelAll_number;
        private ReaLTaiizor.Controls.HopeButton btnNum9;
        private ReaLTaiizor.Controls.HopeButton btnNum0;
        private ReaLTaiizor.Controls.HopeButton btnNum8;
        private ReaLTaiizor.Controls.HopeButton btnNum7;
        private ReaLTaiizor.Controls.HopeButton btnNum6;
        private ReaLTaiizor.Controls.HopeButton btnNumPoint;
        private ReaLTaiizor.Controls.HopeButton btnNum5;
        private ReaLTaiizor.Controls.HopeButton btnNum4;
        private ReaLTaiizor.Controls.HopeButton btnNum3;
        private ReaLTaiizor.Controls.HopeButton btnDel;
        private ReaLTaiizor.Controls.HopeButton btnNum2;
        private ReaLTaiizor.Controls.HopeButton btnNum1;
        private ReaLTaiizor.Controls.CyberSwitch btnDiscountType;
        private ReaLTaiizor.Controls.HopeButton btn30;
        private ReaLTaiizor.Controls.HopeButton btn50;
        private ReaLTaiizor.Controls.HopeButton btn20;
        private ReaLTaiizor.Controls.HopeButton btn10;
        private Label label1;
        private Label label2;
        private Button btnClose;
    }
}