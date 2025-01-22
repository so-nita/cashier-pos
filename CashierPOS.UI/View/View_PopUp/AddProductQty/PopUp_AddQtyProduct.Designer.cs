using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View.View_PopUp.AddProductQty
{
    partial class PopUp_AddQtyProduct
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
            //txtboxDiscount.Focus();
            //txtboxDiscount.Text = string.Empty;
            //price discount
            txtProductQty.Enter += OnMouseHover_Placeholder;
            txtProductQty.Leave += OnMouseLeave_Placeholder;
            txtProductQty.KeyPress += CustomStyle.ValidationNumberOnly;
            txtProductQty.GotFocus += TextBoxSelected;
        }
        private void OnMouseLeave_Placeholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = textBox.Tag.ToString();
                }
            }
        }
        private void OnMouseHover_Placeholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox )
            {
                if (textBox.Text == textBox.Tag.ToString())
                {
                    textBox.Text  = "";
                    textBox.ForeColor = Color.Black;
                }
                else if (textBox.Text != textBox.Tag.ToString())
                {
                    var text = textBox.Text;
                    textBox.Text = text ;
                }
            }
        }
        private void InitializeComponent()
        {
            lbName_QTY = new Label();
            panelHeader_NameQty = new Panel();
            btnClose = new Button();
            txtProductQty = new TextBox();
            txtboxMainEarning = new ReaLTaiizor.Controls.CyberTextBox();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            panelAll_number = new Panel();
            btnNum9 = new ReaLTaiizor.Controls.HopeButton();
            btnNum0 = new ReaLTaiizor.Controls.HopeButton();
            btnNum8 = new ReaLTaiizor.Controls.HopeButton();
            btnNum7 = new ReaLTaiizor.Controls.HopeButton();
            btnNum6 = new ReaLTaiizor.Controls.HopeButton();
            btnNum5 = new ReaLTaiizor.Controls.HopeButton();
            btnNum4 = new ReaLTaiizor.Controls.HopeButton();
            btnNum3 = new ReaLTaiizor.Controls.HopeButton();
            btnDel = new ReaLTaiizor.Controls.HopeButton();
            btnNum2 = new ReaLTaiizor.Controls.HopeButton();
            btnNum1 = new ReaLTaiizor.Controls.HopeButton();
            textBox1 = new TextBox();
            panelHeader_NameQty.SuspendLayout();
            panelAll_number.SuspendLayout();
            SuspendLayout();
            // 
            // lbName_QTY
            // 
            lbName_QTY.AutoSize = true;
            lbName_QTY.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbName_QTY.ForeColor = Color.White;
            lbName_QTY.Location = new Point(73, 12);
            lbName_QTY.Name = "lbName_QTY";
            lbName_QTY.Size = new Size(194, 22);
            lbName_QTY.TabIndex = 1;
            lbName_QTY.Text = "Add Quantity Product ";
            // 
            // panelHeader_NameQty
            // 
            panelHeader_NameQty.BackColor = Color.FromArgb(47, 155, 70);
            panelHeader_NameQty.Controls.Add(btnClose);
            panelHeader_NameQty.Controls.Add(lbName_QTY);
            panelHeader_NameQty.Dock = DockStyle.Top;
            panelHeader_NameQty.Font = new Font("Times New Roman", 14.25F);
            panelHeader_NameQty.Location = new Point(0, 0);
            panelHeader_NameQty.Name = "panelHeader_NameQty";
            panelHeader_NameQty.Size = new Size(328, 48);
            panelHeader_NameQty.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.icon_close22;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(301, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 22);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btn_Close_Click;
            // 
            // txtProductQty
            // 
            txtProductQty.BackColor = Color.White;
            txtProductQty.BorderStyle = BorderStyle.None;
            txtProductQty.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductQty.ForeColor = Color.Black;
            txtProductQty.Location = new Point(107, 103);
            txtProductQty.MaxLength = 3;
            txtProductQty.PlaceholderText = "0";
            txtProductQty.Name = "txtProductQty";
            txtProductQty.Size = new Size(106, 19);
            txtProductQty.TextAlign = HorizontalAlignment.Center;
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
            txtboxMainEarning.Location = new Point(101, 94);
            txtboxMainEarning.Name = "txtboxMainEarning";
            txtboxMainEarning.PenWidth = 15;
            txtboxMainEarning.RGB = false;
            txtboxMainEarning.Rounding = true;
            txtboxMainEarning.RoundingInt = 40;
            txtboxMainEarning.Size = new Size(117, 35);
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
            btnSave.Cursor = Cursors.Hand;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.WindowText;
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(231, 116);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.DeepSkyBlue;
            btnSave.Size = new Size(66, 45);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 51;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.Black;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // panelAll_number
            // 
            panelAll_number.Controls.Add(btnNum9);
            panelAll_number.Controls.Add(btnSave);
            panelAll_number.Controls.Add(btnNum0);
            panelAll_number.Controls.Add(btnNum8);
            panelAll_number.Controls.Add(btnNum7);
            panelAll_number.Controls.Add(btnNum6);
            panelAll_number.Controls.Add(btnNum5);
            panelAll_number.Controls.Add(btnNum4);
            panelAll_number.Controls.Add(btnNum3);
            panelAll_number.Controls.Add(btnDel);
            panelAll_number.Controls.Add(btnNum2);
            panelAll_number.Controls.Add(btnNum1);
            panelAll_number.Location = new Point(7, 146);
            panelAll_number.Name = "panelAll_number";
            panelAll_number.Size = new Size(309, 178);
            panelAll_number.TabIndex = 52;
            // 
            // btnNum9
            // 
            btnNum9.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum9.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum9.Cursor = Cursors.Hand;
            btnNum9.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum9.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum9.ForeColor = SystemColors.WindowText;
            btnNum9.HoverTextColor = Color.DodgerBlue;
            btnNum9.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum9.Location = new Point(158, 116);
            btnNum9.Name = "btnNum9";
            btnNum9.PrimaryColor = Color.White;
            btnNum9.Size = new Size(66, 45);
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
            btnNum0.Cursor = Cursors.Hand;
            btnNum0.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum0.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum0.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum0.ForeColor = SystemColors.WindowText;
            btnNum0.HoverTextColor = Color.DodgerBlue;
            btnNum0.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum0.Location = new Point(231, 65);
            btnNum0.Name = "btnNum0";
            btnNum0.PrimaryColor = Color.White;
            btnNum0.Size = new Size(66, 45);
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
            btnNum8.Cursor = Cursors.Hand;
            btnNum8.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum8.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum8.ForeColor = SystemColors.WindowText;
            btnNum8.HoverTextColor = Color.DodgerBlue;
            btnNum8.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum8.Location = new Point(85, 116);
            btnNum8.Name = "btnNum8";
            btnNum8.PrimaryColor = Color.White;
            btnNum8.Size = new Size(66, 45);
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
            btnNum7.Cursor = Cursors.Hand;
            btnNum7.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum7.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum7.ForeColor = SystemColors.WindowText;
            btnNum7.HoverTextColor = Color.DodgerBlue;
            btnNum7.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum7.Location = new Point(13, 116);
            btnNum7.Name = "btnNum7";
            btnNum7.PrimaryColor = Color.White;
            btnNum7.Size = new Size(66, 45);
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
            btnNum6.Cursor = Cursors.Hand;
            btnNum6.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum6.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum6.ForeColor = SystemColors.WindowText;
            btnNum6.HoverTextColor = Color.DodgerBlue;
            btnNum6.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum6.Location = new Point(158, 65);
            btnNum6.Name = "btnNum6";
            btnNum6.PrimaryColor = Color.White;
            btnNum6.Size = new Size(66, 45);
            btnNum6.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum6.TabIndex = 56;
            btnNum6.Tag = "";
            btnNum6.Text = "6";
            btnNum6.TextColor = Color.Black;
            btnNum6.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum6.Click += InputNumber;
            // 
            // btnNum5
            // 
            btnNum5.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum5.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum5.Cursor = Cursors.Hand;
            btnNum5.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum5.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum5.ForeColor = SystemColors.WindowText;
            btnNum5.HoverTextColor = Color.DodgerBlue;
            btnNum5.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum5.Location = new Point(85, 65);
            btnNum5.Name = "btnNum5";
            btnNum5.PrimaryColor = Color.White;
            btnNum5.Size = new Size(66, 45);
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
            btnNum4.Cursor = Cursors.Hand;
            btnNum4.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum4.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum4.ForeColor = SystemColors.WindowText;
            btnNum4.HoverTextColor = Color.DodgerBlue;
            btnNum4.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum4.Location = new Point(13, 65);
            btnNum4.Name = "btnNum4";
            btnNum4.PrimaryColor = Color.White;
            btnNum4.Size = new Size(66, 45);
            btnNum4.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum4.TabIndex = 53;
            btnNum4.Tag = "";
            btnNum4.Text = "4";
            btnNum4.TextColor = Color.Black;
            btnNum4.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum4.Click += InputNumber;
            // 
            // btnNum3
            // 
            btnNum3.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum3.Cursor = Cursors.Hand;
            btnNum3.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum3.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum3.ForeColor = SystemColors.WindowText;
            btnNum3.HoverTextColor = Color.DodgerBlue;
            btnNum3.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum3.Location = new Point(158, 14);
            btnNum3.Name = "btnNum3";
            btnNum3.PrimaryColor = Color.White;
            btnNum3.Size = new Size(66, 45);
            btnNum3.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum3.TabIndex = 52;
            btnNum3.Tag = "";
            btnNum3.Text = "3";
            btnNum3.TextColor = Color.Black;
            btnNum3.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum3.Click += InputNumber;
            // 
            // btnDel
            // 
            btnDel.BorderColor = Color.FromArgb(220, 223, 230);
            btnDel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDel.Cursor = Cursors.Hand;
            btnDel.DangerColor = Color.FromArgb(245, 108, 108);
            btnDel.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnDel.ForeColor = SystemColors.WindowText;
            btnDel.HoverTextColor = Color.DodgerBlue;
            btnDel.InfoColor = Color.FromArgb(144, 147, 153);
            btnDel.Location = new Point(231, 14);
            btnDel.Name = "btnDel";
            btnDel.PrimaryColor = Color.White;
            btnDel.Size = new Size(66, 45);
            btnDel.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDel.TabIndex = 51;
            btnDel.Text = "Del";
            btnDel.TextColor = Color.Black;
            btnDel.WarningColor = Color.FromArgb(230, 162, 60);
            btnDel.Click += btnDel_Click;
            // 
            // btnNum2
            // 
            btnNum2.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum2.Cursor = Cursors.Hand;
            btnNum2.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum2.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNum2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum2.ForeColor = SystemColors.WindowText;
            btnNum2.HoverTextColor = Color.DodgerBlue;
            btnNum2.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum2.Location = new Point(85, 14);
            btnNum2.Name = "btnNum2";
            btnNum2.PrimaryColor = Color.White;
            btnNum2.Size = new Size(66, 45);
            btnNum2.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum2.TabIndex = 50;
            btnNum2.Tag = "";
            btnNum2.Text = "2";
            btnNum2.TextColor = Color.Black;
            btnNum2.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum2.Click += InputNumber;
            // 
            // btnNum1
            // 
            btnNum1.BorderColor = Color.FromArgb(220, 223, 230);
            btnNum1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNum1.Cursor = Cursors.Hand;
            btnNum1.DangerColor = Color.FromArgb(245, 108, 108);
            btnNum1.DefaultColor = Color.White;
            btnNum1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNum1.ForeColor = SystemColors.WindowText;
            btnNum1.HoverTextColor = Color.DodgerBlue;
            btnNum1.InfoColor = Color.FromArgb(144, 147, 153);
            btnNum1.Location = new Point(13, 14);
            btnNum1.Name = "btnNum1";
            btnNum1.PrimaryColor = Color.White;
            btnNum1.Size = new Size(66, 45);
            btnNum1.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNum1.TabIndex = 49;
            btnNum1.Tag = "";
            btnNum1.Text = "1";
            btnNum1.TextColor = Color.Black;
            btnNum1.WarningColor = Color.FromArgb(230, 162, 60);
            btnNum1.Click += InputNumber;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 11.25F);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(12, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 18);
            textBox1.TabIndex = 53;
            textBox1.Tag = "";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PopUp_AddQtyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 213);
            ClientSize = new Size(328, 350);
            Controls.Add(textBox1);
            Controls.Add(panelAll_number);
            Controls.Add(txtProductQty);
            Controls.Add(txtboxMainEarning);
            Controls.Add(panelHeader_NameQty);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_AddQtyProduct";
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader_NameQty.ResumeLayout(false);
            panelHeader_NameQty.PerformLayout();
            panelAll_number.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName_QTY;
        private Panel panelHeader_NameQty;
        private TextBox txtProductQty;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainEarning;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private Panel panelAll_number;
        private ReaLTaiizor.Controls.HopeButton btnNum9;
        private ReaLTaiizor.Controls.HopeButton btnNum0;
        private ReaLTaiizor.Controls.HopeButton btnNum8;
        private ReaLTaiizor.Controls.HopeButton btnNum7;
        private ReaLTaiizor.Controls.HopeButton btnNum6;
        private ReaLTaiizor.Controls.HopeButton btnNum5;
        private ReaLTaiizor.Controls.HopeButton btnNum4;
        private ReaLTaiizor.Controls.HopeButton btnNum3;
        private ReaLTaiizor.Controls.HopeButton btnDel;
        private ReaLTaiizor.Controls.HopeButton btnNum2;
        private ReaLTaiizor.Controls.HopeButton btnNum1;
        private Button btnClose;
        private TextBox textBox1;
    }
}