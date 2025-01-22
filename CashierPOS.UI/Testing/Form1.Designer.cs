
using CashierPOS.UI.CustomStyles;

namespace TestReceipt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            panelSearch = new ReaLTaiizor.Controls.MaterialCard();
            textBox_ScanInput = new TextBox();
            panelCategory = new Panel();
            dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            panel1 = new Panel();
            button1 = new Button();
            comboBoxReason = new ReaLTaiizor.Controls.DungeonComboBox();
            txtboxMainReason = new ReaLTaiizor.Controls.CyberTextBox();
            exportPDF = new ReaLTaiizor.Controls.HopeButton();
            label6 = new Label();
            label9 = new Label();
            label5 = new Label();
            lbNameUserID = new Label();
            panelHeaderPaymentOption = new Panel();
            btnClose = new Button();
            lbNamePaymentOption = new Label();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            objectAnimator1 = new ReaLTaiizor.Animate.Parrot.ObjectAnimator();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panelCategory.SuspendLayout();
            panel1.SuspendLayout();
            panelHeaderPaymentOption.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSize = true;
            panelHeader.BackColor = Color.FromArgb(16, 107, 67);
            panelHeader.Controls.Add(panelSearch);
            panelHeader.Controls.Add(panelCategory);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(549, 410);
            panelHeader.TabIndex = 18;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelSearch.BackColor = Color.FromArgb(255, 255, 255);
            panelSearch.Controls.Add(textBox_ScanInput);
            panelSearch.Depth = 0;
            panelSearch.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelSearch.Location = new Point(-30638, 11);
            panelSearch.Margin = new Padding(14);
            panelSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(14);
            panelSearch.Size = new Size(159, 672);
            panelSearch.TabIndex = 3;
            // 
            // textBox_ScanInput
            // 
            textBox_ScanInput.BorderStyle = BorderStyle.None;
            textBox_ScanInput.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ScanInput.ForeColor = Color.DarkGray;
            textBox_ScanInput.Location = new Point(0, 9);
            textBox_ScanInput.Name = "textBox_ScanInput";
            textBox_ScanInput.Size = new Size(148, 14);
            textBox_ScanInput.TabIndex = 4;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.FromArgb(176, 215, 181);
            panelCategory.Controls.Add(dungeonComboBox1);
            panelCategory.Controls.Add(cyberTextBox1);
            panelCategory.Controls.Add(panel1);
            panelCategory.Controls.Add(exportPDF);
            panelCategory.Controls.Add(label6);
            panelCategory.Controls.Add(label9);
            panelCategory.Controls.Add(label5);
            panelCategory.Controls.Add(lbNameUserID);
            panelCategory.Controls.Add(panelHeaderPaymentOption);
            panelCategory.Controls.Add(btnSave);
            panelCategory.Cursor = Cursors.Hand;
            panelCategory.Dock = DockStyle.Fill;
            panelCategory.Location = new Point(0, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(549, 410);
            panelCategory.TabIndex = 4;
            // 
            // dungeonComboBox1
            // 
            dungeonComboBox1.BackColor = Color.White;
            dungeonComboBox1.ColorA = Color.White;
            dungeonComboBox1.ColorB = Color.White;
            dungeonComboBox1.ColorC = Color.White;
            dungeonComboBox1.ColorD = Color.White;
            dungeonComboBox1.ColorE = Color.White;
            dungeonComboBox1.ColorF = Color.White;
            dungeonComboBox1.ColorG = Color.FromArgb(119, 119, 118);
            dungeonComboBox1.ColorH = Color.FromArgb(224, 222, 220);
            dungeonComboBox1.ColorI = Color.White;
            dungeonComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            dungeonComboBox1.DropDownHeight = 300;
            dungeonComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dungeonComboBox1.Font = new Font("Segoe UI", 10F);
            dungeonComboBox1.ForeColor = Color.Black;
            dungeonComboBox1.HoverSelectionColor = Color.Empty;
            dungeonComboBox1.IntegralHeight = false;
            dungeonComboBox1.ItemHeight = 26;
            dungeonComboBox1.Location = new Point(169, 190);
            dungeonComboBox1.Name = "dungeonComboBox1";
            dungeonComboBox1.Size = new Size(211, 32);
            dungeonComboBox1.StartIndex = 0;
            dungeonComboBox1.TabIndex = 87;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 1F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(47, 155, 70);
            cyberTextBox1.ColorBackground_Pen = Color.FromArgb(47, 155, 70);
            cyberTextBox1.ColorLighting = Color.White;
            cyberTextBox1.ColorPen_1 = Color.White;
            cyberTextBox1.ColorPen_2 = Color.White;
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Font = new Font("Arial", 8F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(166, 188);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 40;
            cyberTextBox1.Size = new Size(216, 35);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 86;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 155, 70);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBoxReason);
            panel1.Controls.Add(txtboxMainReason);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 14.25F);
            panel1.Location = new Point(0, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 48);
            panel1.TabIndex = 85;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = CashierPOS.UI.Properties.Resources.close_white;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1528, 3);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxReason
            // 
            comboBoxReason.BackColor = Color.White;
            comboBoxReason.ColorA = Color.FromArgb(16, 107, 67);
            comboBoxReason.ColorB = Color.FromArgb(16, 107, 67);
            comboBoxReason.ColorC = Color.White;
            comboBoxReason.ColorD = Color.White;
            comboBoxReason.ColorE = Color.White;
            comboBoxReason.ColorF = Color.White;
            comboBoxReason.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxReason.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxReason.ColorI = Color.White;
            comboBoxReason.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxReason.DropDownHeight = 300;
            comboBoxReason.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReason.Font = new Font("Segoe UI", 10F);
            comboBoxReason.ForeColor = Color.Black;
            comboBoxReason.HoverSelectionColor = Color.Empty;
            comboBoxReason.IntegralHeight = false;
            comboBoxReason.ItemHeight = 26;
            comboBoxReason.Location = new Point(154, 7);
            comboBoxReason.Name = "comboBoxReason";
            comboBoxReason.Size = new Size(211, 32);
            comboBoxReason.StartIndex = 0;
            comboBoxReason.TabIndex = 83;
            comboBoxReason.Click += comboBoxReason_SelectedIndexChanged;
            // 
            // txtboxMainReason
            // 
            txtboxMainReason.Alpha = 20;
            txtboxMainReason.BackColor = Color.Transparent;
            txtboxMainReason.Background_WidthPen = 1F;
            txtboxMainReason.BackgroundPen = true;
            txtboxMainReason.ColorBackground = Color.FromArgb(47, 155, 70);
            txtboxMainReason.ColorBackground_Pen = Color.FromArgb(47, 155, 70);
            txtboxMainReason.ColorLighting = Color.White;
            txtboxMainReason.ColorPen_1 = Color.White;
            txtboxMainReason.ColorPen_2 = Color.White;
            txtboxMainReason.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainReason.Font = new Font("Arial", 8F);
            txtboxMainReason.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainReason.Lighting = false;
            txtboxMainReason.LinearGradientPen = false;
            txtboxMainReason.Location = new Point(151, 5);
            txtboxMainReason.Name = "txtboxMainReason";
            txtboxMainReason.PenWidth = 15;
            txtboxMainReason.RGB = false;
            txtboxMainReason.Rounding = true;
            txtboxMainReason.RoundingInt = 40;
            txtboxMainReason.Size = new Size(216, 35);
            txtboxMainReason.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainReason.TabIndex = 81;
            txtboxMainReason.Tag = "Cyber";
            txtboxMainReason.TextButton = "";
            txtboxMainReason.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainReason.Timer_RGB = 300;
            // 
            // exportPDF
            // 
            exportPDF.BorderColor = Color.FromArgb(220, 223, 230);
            exportPDF.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            exportPDF.DangerColor = Color.FromArgb(245, 108, 108);
            exportPDF.DefaultColor = Color.FromArgb(255, 255, 255);
            exportPDF.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportPDF.ForeColor = SystemColors.WindowText;
            exportPDF.HoverTextColor = Color.FromArgb(48, 49, 51);
            exportPDF.InfoColor = Color.FromArgb(144, 147, 153);
            exportPDF.Location = new Point(157, 317);
            exportPDF.Name = "exportPDF";
            exportPDF.PrimaryColor = Color.FromArgb(47, 155, 70);
            exportPDF.Size = new Size(128, 38);
            exportPDF.SuccessColor = Color.FromArgb(103, 194, 58);
            exportPDF.TabIndex = 84;
            exportPDF.Text = "Export PDF";
            exportPDF.TextColor = Color.White;
            exportPDF.WarningColor = Color.FromArgb(230, 162, 60);
            exportPDF.Click += exportPDF_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(333, 87);
            label6.Name = "label6";
            label6.Size = new Size(17, 19);
            label6.TabIndex = 80;
            label6.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(269, 88);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 79;
            label9.Text = "User ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(86, 80);
            label5.Name = "label5";
            label5.Size = new Size(17, 19);
            label5.TabIndex = 76;
            label5.Text = "*";
            // 
            // lbNameUserID
            // 
            lbNameUserID.AutoSize = true;
            lbNameUserID.Font = new Font("Times New Roman", 12F);
            lbNameUserID.ForeColor = SystemColors.WindowText;
            lbNameUserID.Location = new Point(30, 87);
            lbNameUserID.Name = "lbNameUserID";
            lbNameUserID.Size = new Size(58, 19);
            lbNameUserID.TabIndex = 75;
            lbNameUserID.Text = "User ID";
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
            panelHeaderPaymentOption.Size = new Size(549, 48);
            panelHeaderPaymentOption.TabIndex = 67;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = CashierPOS.UI.Properties.Resources.close_white;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1179, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 27);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = true;
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
            // btnSave
            // 
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.WindowText;
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(354, 317);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnSave.Size = new Size(128, 38);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(549, 410);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panelHeader.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelCategory.ResumeLayout(false);
            panelCategory.PerformLayout();
            panel1.ResumeLayout(false);
            panelHeaderPaymentOption.ResumeLayout(false);
            panelHeaderPaymentOption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private ReaLTaiizor.Controls.MaterialCard panelSearch;
        private TextBox textBox_ScanInput;
        private Panel panelCategory;
        private Label label6;
        private Label label9;
        private Label label5;
        private Label lbNameUserID;
        private Panel panelHeaderPaymentOption;
        private Button btnClose;
        private Label lbNamePaymentOption;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private ReaLTaiizor.Animate.Parrot.ObjectAnimator objectAnimator1;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainReason;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxReason;
        private ReaLTaiizor.Controls.HopeButton exportPDF;
        private Panel panel1;
        private Button button1;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
    }
}
