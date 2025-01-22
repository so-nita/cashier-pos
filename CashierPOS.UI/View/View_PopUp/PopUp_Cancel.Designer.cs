namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_Cancel
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
            panelCancel = new Panel();
            comboBoxReason = new ReaLTaiizor.Controls.DungeonComboBox();
            txtboxMainReason = new ReaLTaiizor.Controls.CyberTextBox();
            pictureBoxRedStarCancel = new PictureBox();
            lbNameReason = new Label();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderCancel = new Panel();
            btnCloseCancel = new Button();
            lbNameCancel = new Label();
            panelCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarCancel).BeginInit();
            panelHeaderCancel.SuspendLayout();
            SuspendLayout();
            // 
            // panelCancel
            // 
            panelCancel.BackColor = Color.FromArgb(176, 215, 181);
            panelCancel.Controls.Add(comboBoxReason);
            panelCancel.Controls.Add(txtboxMainReason);
            panelCancel.Controls.Add(pictureBoxRedStarCancel);
            panelCancel.Controls.Add(lbNameReason);
            panelCancel.Controls.Add(btnCancle);
            panelCancel.Controls.Add(btnSave);
            panelCancel.Controls.Add(panelHeaderCancel);
            panelCancel.Location = new Point(0, 0);
            panelCancel.Name = "panelCancel";
            panelCancel.Size = new Size(368, 190);
            panelCancel.TabIndex = 3;
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
            comboBoxReason.Location = new Point(122, 77);
            comboBoxReason.Name = "comboBoxReason";
            comboBoxReason.Size = new Size(211, 32);
            comboBoxReason.StartIndex = 0;
            comboBoxReason.TabIndex = 89;
            comboBoxReason.Click += comboBoxReason_SelectedIndexChanged;
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
            txtboxMainReason.Location = new Point(119, 75);
            txtboxMainReason.Name = "txtboxMainReason";
            txtboxMainReason.PenWidth = 15;
            txtboxMainReason.RGB = false;
            txtboxMainReason.Rounding = true;
            txtboxMainReason.RoundingInt = 40;
            txtboxMainReason.Size = new Size(216, 35);
            txtboxMainReason.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainReason.TabIndex = 88;
            txtboxMainReason.Tag = "Cyber";
            txtboxMainReason.TextButton = "";
            txtboxMainReason.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainReason.Timer_RGB = 300;
            // 
            // pictureBoxRedStarCancel
            // 
            pictureBoxRedStarCancel.BackgroundImage = Properties.Resources.redstar;
            pictureBoxRedStarCancel.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRedStarCancel.Location = new Point(78, 82);
            pictureBoxRedStarCancel.Name = "pictureBoxRedStarCancel";
            pictureBoxRedStarCancel.Size = new Size(10, 13);
            pictureBoxRedStarCancel.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRedStarCancel.TabIndex = 40;
            pictureBoxRedStarCancel.TabStop = false;
            // 
            // lbNameReason
            // 
            lbNameReason.AutoSize = true;
            lbNameReason.Font = new Font("Times New Roman", 12F);
            lbNameReason.ForeColor = SystemColors.WindowText;
            lbNameReason.Location = new Point(27, 84);
            lbNameReason.Name = "lbNameReason";
            lbNameReason.Size = new Size(54, 19);
            lbNameReason.TabIndex = 37;
            lbNameReason.Text = "Reason";
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
            btnCancle.Location = new Point(179, 135);
            btnCancle.Name = "btnCancle";
            btnCancle.PrimaryColor = Color.Red;
            btnCancle.Size = new Size(75, 31);
            btnCancle.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancle.TabIndex = 36;
            btnCancle.Text = "Cancel";
            btnCancle.TextColor = Color.White;
            btnCancle.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancle.Click += btnCancle_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(176, 215, 181);
            btnSave.BorderColor = Color.FromArgb(220, 223, 230);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSave.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(144, 147, 153);
            btnSave.Location = new Point(260, 135);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnSave.Size = new Size(75, 31);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // panelHeaderCancel
            // 
            panelHeaderCancel.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderCancel.Controls.Add(btnCloseCancel);
            panelHeaderCancel.Controls.Add(lbNameCancel);
            panelHeaderCancel.Location = new Point(0, 0);
            panelHeaderCancel.Name = "panelHeaderCancel";
            panelHeaderCancel.Size = new Size(368, 48);
            panelHeaderCancel.TabIndex = 0;
            // 
            // btnCloseCancel
            // 
            btnCloseCancel.BackgroundImage = Properties.Resources.can_t1;
            btnCloseCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseCancel.FlatAppearance.BorderSize = 0;
            btnCloseCancel.FlatStyle = FlatStyle.Flat;
            btnCloseCancel.Location = new Point(346, 8);
            btnCloseCancel.Name = "btnCloseCancel";
            btnCloseCancel.Size = new Size(15, 14);
            btnCloseCancel.TabIndex = 3;
            btnCloseCancel.UseVisualStyleBackColor = true;
            btnCloseCancel.Click += btnCloseCancel_Click;
            // 
            // lbNameCancel
            // 
            lbNameCancel.AutoSize = true;
            lbNameCancel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameCancel.ForeColor = Color.White;
            lbNameCancel.Location = new Point(147, 13);
            lbNameCancel.Name = "lbNameCancel";
            lbNameCancel.Size = new Size(67, 22);
            lbNameCancel.TabIndex = 1;
            lbNameCancel.Text = "Cancel";
            // 
            // PopUp_Cancel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 190);
            Controls.Add(panelCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_Cancel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Cancel";
            panelCancel.ResumeLayout(false);
            panelCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarCancel).EndInit();
            panelHeaderCancel.ResumeLayout(false);
            panelHeaderCancel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCancel;
        private PictureBox pictureBox1;
        private TextBox txtboxInvoiceNo;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainInvoiceNo;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private ReaLTaiizor.Controls.HopeButton btnBack;
        private Panel panelHeaderCancel;
        public Label lbNameCancel;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private Label lbNameReason;
        private PictureBox pictureBoxRedStarCancel;
        private Button btnCloseCancel;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxReason;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainReason;
    }
}