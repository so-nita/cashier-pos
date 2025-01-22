using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_Return
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
            // Invoice No
            txtboxInvoiceNo.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxInvoiceNo.Leave += CustomStyle.OnMouseLeave_Placeholder;
            CustomStyle.AttachDynamicKeyEvent(txtboxInvoiceNo, txtboxBarCode);

            // Barcode
            txtboxBarCode.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxBarCode.Leave += CustomStyle.OnMouseLeave_Placeholder;
            CustomStyle.AttachDynamicKeyEvent(txtboxBarCode, txtboxInvoiceNo);

            btnCloseReturn.Click += btnCloseReturn_Click;
            btnSearch.Click += btnSearch_Click;
            btnCancle.Click += btnCancle_Click;
        }
        /// </summary>
        private void InitializeComponent()
        {
            panelReturnForm = new Panel();
            comboBoxReason = new ReaLTaiizor.Controls.DungeonComboBox();
            txtboxMainReason = new ReaLTaiizor.Controls.CyberTextBox();
            pictureBoxRedStarReason = new PictureBox();
            lbNameReason = new Label();
            pictureBoxRedStarInvoice = new PictureBox();
            txtboxBarCode = new TextBox();
            txtboxInvoiceNo = new TextBox();
            btnSearch = new ReaLTaiizor.Controls.HopeButton();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            txtboxMainBarCode = new ReaLTaiizor.Controls.CyberTextBox();
            txtboxInvoiceNoMain = new ReaLTaiizor.Controls.CyberTextBox();
            lbNameBarCode = new Label();
            lbNameInvoiceNo = new Label();
            panelHeaderReturn = new Panel();
            btnCloseReturn = new Button();
            lbNameReturn = new Label();
            panelReturnForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarReason).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarInvoice).BeginInit();
            panelHeaderReturn.SuspendLayout();
            SuspendLayout();
            // 
            // panelReturnForm
            // 
            panelReturnForm.BackColor = Color.FromArgb(176, 215, 181);
            panelReturnForm.Controls.Add(comboBoxReason);
            panelReturnForm.Controls.Add(txtboxMainReason);
            panelReturnForm.Controls.Add(pictureBoxRedStarReason);
            panelReturnForm.Controls.Add(lbNameReason);
            panelReturnForm.Controls.Add(pictureBoxRedStarInvoice);
            panelReturnForm.Controls.Add(txtboxBarCode);
            panelReturnForm.Controls.Add(txtboxInvoiceNo);
            panelReturnForm.Controls.Add(btnSearch);
            panelReturnForm.Controls.Add(btnCancle);
            panelReturnForm.Controls.Add(txtboxMainBarCode);
            panelReturnForm.Controls.Add(txtboxInvoiceNoMain);
            panelReturnForm.Controls.Add(lbNameBarCode);
            panelReturnForm.Controls.Add(lbNameInvoiceNo);
            panelReturnForm.Controls.Add(panelHeaderReturn);
            panelReturnForm.Location = new Point(0, 0);
            panelReturnForm.Name = "panelReturnForm";
            panelReturnForm.Size = new Size(368, 312);
            panelReturnForm.TabIndex = 2;
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
            comboBoxReason.Location = new Point(122, 194);
            comboBoxReason.Name = "comboBoxReason";
            comboBoxReason.Size = new Size(220, 32);
            comboBoxReason.StartIndex = 0;
            comboBoxReason.TabIndex = 91;
            //comboBoxReason.SelectedIndexChanged += comboBoxReason_SelectedIndexChanged;
            comboBoxReason.Click += comboBoxReason_Click;
            // 
            // txtboxMainReason
            // 
            txtboxMainReason.Alpha = 20;
            txtboxMainReason.BackColor = Color.Transparent;
            txtboxMainReason.Background_WidthPen = 1F;
            txtboxMainReason.BackgroundPen = true;
            txtboxMainReason.ColorBackground = Color.FromArgb(176, 215, 181);
            txtboxMainReason.ColorBackground_Pen = Color.FromArgb(176, 215, 181);
            txtboxMainReason.ColorLighting = Color.White;
            txtboxMainReason.ColorPen_1 = Color.White;
            txtboxMainReason.ColorPen_2 = Color.White;
            txtboxMainReason.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainReason.Font = new Font("Arial", 8F);
            txtboxMainReason.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainReason.Lighting = false;
            txtboxMainReason.LinearGradientPen = false;
            txtboxMainReason.Location = new Point(119, 192);
            txtboxMainReason.Name = "txtboxMainReason";
            txtboxMainReason.PenWidth = 15;
            txtboxMainReason.RGB = false;
            txtboxMainReason.Rounding = true;
            txtboxMainReason.RoundingInt = 40;
            txtboxMainReason.Size = new Size(224, 35);
            txtboxMainReason.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainReason.TabIndex = 90;
            txtboxMainReason.Tag = "Cyber";
            txtboxMainReason.TextButton = "";
            txtboxMainReason.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainReason.Timer_RGB = 300;
            // 
            // pictureBoxRedStarReason
            // 
            pictureBoxRedStarReason.BackgroundImage = Properties.Resources.redstar;
            pictureBoxRedStarReason.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRedStarReason.Location = new Point(78, 196);
            pictureBoxRedStarReason.Name = "pictureBoxRedStarReason";
            pictureBoxRedStarReason.Size = new Size(10, 13);
            pictureBoxRedStarReason.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRedStarReason.TabIndex = 35;
            pictureBoxRedStarReason.TabStop = false;
            // 
            // lbNameReason
            // 
            lbNameReason.AutoSize = true;
            lbNameReason.Font = new Font("Times New Roman", 12F);
            lbNameReason.ForeColor = SystemColors.WindowText;
            lbNameReason.Location = new Point(29, 199);
            lbNameReason.Name = "lbNameReason";
            lbNameReason.Size = new Size(54, 19);
            lbNameReason.TabIndex = 32;
            lbNameReason.Text = "Reason";
            // 
            // pictureBoxRedStarInvoice
            // 
            pictureBoxRedStarInvoice.BackgroundImage = Properties.Resources.redstar;
            pictureBoxRedStarInvoice.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRedStarInvoice.Location = new Point(96, 90);
            pictureBoxRedStarInvoice.Name = "pictureBoxRedStarInvoice";
            pictureBoxRedStarInvoice.Size = new Size(10, 13);
            pictureBoxRedStarInvoice.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRedStarInvoice.TabIndex = 26;
            pictureBoxRedStarInvoice.TabStop = false;
            // 
            // txtboxBarCode
            // 
            txtboxBarCode.BackColor = Color.White;
            txtboxBarCode.BorderStyle = BorderStyle.None;
            txtboxBarCode.Font = new Font("Times New Roman", 11.25F);
            txtboxBarCode.ForeColor = Color.DarkGray;
            txtboxBarCode.Location = new Point(132, 147);
            txtboxBarCode.Name = "txtboxBarCode";
            txtboxBarCode.PlaceholderText = "Scan or input";
            txtboxBarCode.Size = new Size(203, 18);
            txtboxBarCode.TabIndex = 19;
            txtboxBarCode.Tag = "Scan or input";
            // 
            // txtboxInvoiceNo
            // 
            txtboxInvoiceNo.BackColor = Color.White;
            txtboxInvoiceNo.BorderStyle = BorderStyle.None;
            txtboxInvoiceNo.Font = new Font("Times New Roman", 11.25F);
            txtboxInvoiceNo.ForeColor = Color.Black;
            txtboxInvoiceNo.Location = new Point(132, 95);
            txtboxInvoiceNo.Name = "txtboxInvoiceNo";
            txtboxInvoiceNo.PlaceholderText = "Scan or input";
            txtboxInvoiceNo.Size = new Size(203, 18);
            txtboxInvoiceNo.TabIndex = 18;
            txtboxInvoiceNo.Tag = "";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(176, 215, 181);
            btnSearch.BorderColor = Color.FromArgb(220, 223, 230);
            btnSearch.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.DangerColor = Color.FromArgb(245, 108, 108);
            btnSearch.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearch.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSearch.InfoColor = Color.FromArgb(144, 147, 153);
            btnSearch.Location = new Point(269, 260);
            btnSearch.Name = "btnSearch";
            btnSearch.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnSearch.Size = new Size(73, 32);
            btnSearch.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.White;
            btnSearch.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnCancle
            // 
            btnCancle.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancle.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancle.Cursor = Cursors.Hand;
            btnCancle.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancle.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancle.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancle.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancle.Location = new Point(184, 260);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(73, 32);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 7;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // txtboxMainBarCode
            // 
            txtboxMainBarCode.Alpha = 20;
            txtboxMainBarCode.BackColor = Color.Transparent;
            txtboxMainBarCode.Background_WidthPen = 1F;
            txtboxMainBarCode.BackgroundPen = true;
            txtboxMainBarCode.ColorBackground = Color.White;
            txtboxMainBarCode.ColorBackground_Pen = Color.White;
            txtboxMainBarCode.ColorLighting = Color.White;
            txtboxMainBarCode.ColorPen_1 = Color.White;
            txtboxMainBarCode.ColorPen_2 = Color.White;
            txtboxMainBarCode.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainBarCode.Font = new Font("Arial", 8F);
            txtboxMainBarCode.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainBarCode.Lighting = false;
            txtboxMainBarCode.LinearGradientPen = false;
            txtboxMainBarCode.Location = new Point(122, 137);
            txtboxMainBarCode.Name = "txtboxMainBarCode";
            txtboxMainBarCode.PenWidth = 15;
            txtboxMainBarCode.RGB = false;
            txtboxMainBarCode.Rounding = true;
            txtboxMainBarCode.RoundingInt = 40;
            txtboxMainBarCode.Size = new Size(221, 35);
            txtboxMainBarCode.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainBarCode.TabIndex = 6;
            txtboxMainBarCode.Tag = "Cyber";
            txtboxMainBarCode.TextButton = "";
            txtboxMainBarCode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainBarCode.Timer_RGB = 300;
            // 
            // txtboxInvoiceNoMain
            // 
            txtboxInvoiceNoMain.Alpha = 20;
            txtboxInvoiceNoMain.BackColor = Color.Transparent;
            txtboxInvoiceNoMain.Background_WidthPen = 1F;
            txtboxInvoiceNoMain.BackgroundPen = true;
            txtboxInvoiceNoMain.ColorBackground = Color.White;
            txtboxInvoiceNoMain.ColorBackground_Pen = Color.White;
            txtboxInvoiceNoMain.ColorLighting = Color.White;
            txtboxInvoiceNoMain.ColorPen_1 = Color.White;
            txtboxInvoiceNoMain.ColorPen_2 = Color.White;
            txtboxInvoiceNoMain.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxInvoiceNoMain.Font = new Font("Arial", 8F);
            txtboxInvoiceNoMain.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxInvoiceNoMain.Lighting = false;
            txtboxInvoiceNoMain.LinearGradientPen = false;
            txtboxInvoiceNoMain.Location = new Point(122, 85);
            txtboxInvoiceNoMain.Name = "txtboxInvoiceNoMain";
            txtboxInvoiceNoMain.PenWidth = 15;
            txtboxInvoiceNoMain.RGB = false;
            txtboxInvoiceNoMain.Rounding = true;
            txtboxInvoiceNoMain.RoundingInt = 40;
            txtboxInvoiceNoMain.Size = new Size(221, 35);
            txtboxInvoiceNoMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxInvoiceNoMain.TabIndex = 5;
            txtboxInvoiceNoMain.Tag = "InoviceNo";
            txtboxInvoiceNoMain.TextButton = "";
            txtboxInvoiceNoMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxInvoiceNoMain.Timer_RGB = 300;
            // 
            // lbNameBarCode
            // 
            lbNameBarCode.AutoSize = true;
            lbNameBarCode.Font = new Font("Times New Roman", 12F);
            lbNameBarCode.ForeColor = SystemColors.WindowText;
            lbNameBarCode.Location = new Point(29, 145);
            lbNameBarCode.Name = "lbNameBarCode";
            lbNameBarCode.Size = new Size(65, 19);
            lbNameBarCode.TabIndex = 2;
            lbNameBarCode.Text = "BarCode";
            // 
            // lbNameInvoiceNo
            // 
            lbNameInvoiceNo.AutoSize = true;
            lbNameInvoiceNo.Font = new Font("Times New Roman", 12F);
            lbNameInvoiceNo.ForeColor = SystemColors.WindowText;
            lbNameInvoiceNo.Location = new Point(29, 94);
            lbNameInvoiceNo.Name = "lbNameInvoiceNo";
            lbNameInvoiceNo.Size = new Size(72, 19);
            lbNameInvoiceNo.TabIndex = 1;
            lbNameInvoiceNo.Text = "Invoice №";
            // 
            // panelHeaderReturn
            // 
            panelHeaderReturn.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderReturn.Controls.Add(btnCloseReturn);
            panelHeaderReturn.Controls.Add(lbNameReturn);
            panelHeaderReturn.Location = new Point(0, 0);
            panelHeaderReturn.Name = "panelHeaderReturn";
            panelHeaderReturn.Size = new Size(368, 48);
            panelHeaderReturn.TabIndex = 0;
            // 
            // btnCloseReturn
            // 
            btnCloseReturn.BackgroundImage = Properties.Resources.can_t1;
            btnCloseReturn.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseReturn.Cursor = Cursors.Hand;
            btnCloseReturn.FlatAppearance.BorderSize = 0;
            btnCloseReturn.FlatStyle = FlatStyle.Flat;
            btnCloseReturn.Location = new Point(342, 7);
            btnCloseReturn.Name = "btnCloseReturn";
            btnCloseReturn.Size = new Size(20, 20);
            btnCloseReturn.TabIndex = 9;
            btnCloseReturn.UseVisualStyleBackColor = true;
            // 
            // lbNameReturn
            // 
            lbNameReturn.AutoSize = true;
            lbNameReturn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameReturn.ForeColor = Color.White;
            lbNameReturn.Location = new Point(154, 13);
            lbNameReturn.Name = "lbNameReturn";
            lbNameReturn.Size = new Size(67, 22);
            lbNameReturn.TabIndex = 1;
            lbNameReturn.Text = "Return";
            // 
            // PopUp_Return
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 312);
            Controls.Add(panelReturnForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_Return";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Return";
            Load += InitailizeLoad_Component;
            panelReturnForm.ResumeLayout(false);
            panelReturnForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarReason).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarInvoice).EndInit();
            panelHeaderReturn.ResumeLayout(false);
            panelHeaderReturn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReturnForm;
        private TextBox txtboxBarCode;
        private TextBox txtboxInvoiceNo;
        private ReaLTaiizor.Controls.HopeButton btnSearch;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainBarCode;
        private ReaLTaiizor.Controls.CyberTextBox txtboxInvoiceNoMain;
        private Label lbNameBarCode;
        private Label lbNameInvoiceNo;
        private Panel panelHeaderReturn;
        private Label lbNameReturn;
        private PictureBox pictureBoxRedStarInvoice;
        private Label lbNameReason;
        private PictureBox pictureBoxRedStarReason;
        bool isInitialSelection = true;

        private void comboBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitialSelection)
            {
                comboBoxReason.SelectedIndex = -1;
                isInitialSelection = false;
            }
        }

        private Button btnCloseReturn;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxReason;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainReason;
    }

}