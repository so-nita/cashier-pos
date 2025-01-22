namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_Delete
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
            panelDelete = new Panel();
            comboBoxReason = new ReaLTaiizor.Controls.DungeonComboBox();
            txtboxMainReason = new ReaLTaiizor.Controls.CyberTextBox();
            pictureBoxRedStarDelete = new PictureBox();
            lbNameReason = new Label();
            btnCancle = new ReaLTaiizor.Controls.HopeButton();
            btnSave = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderDelete = new Panel();
            btnCloseDelete = new Button();
            lbNameDelete = new Label();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarDelete).BeginInit();
            panelHeaderDelete.SuspendLayout();
            SuspendLayout();
            // 
            // panelDelete
            // 
            panelDelete.BackColor = Color.FromArgb(176, 215, 181);
            panelDelete.Controls.Add(comboBoxReason);
            panelDelete.Controls.Add(txtboxMainReason);
            panelDelete.Controls.Add(pictureBoxRedStarDelete);
            panelDelete.Controls.Add(lbNameReason);
            panelDelete.Controls.Add(btnCancle);
            panelDelete.Controls.Add(btnSave);
            panelDelete.Controls.Add(panelHeaderDelete);
            panelDelete.Location = new Point(0, 0);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(368, 190);
            panelDelete.TabIndex = 4;
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
            comboBoxReason.Location = new Point(122, 79);
            comboBoxReason.Name = "comboBoxReason";
            comboBoxReason.Size = new Size(211, 32);
            comboBoxReason.StartIndex = 0;
            comboBoxReason.TabIndex = 91;
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
            txtboxMainReason.Location = new Point(119, 77);
            txtboxMainReason.Name = "txtboxMainReason";
            txtboxMainReason.PenWidth = 15;
            txtboxMainReason.RGB = false;
            txtboxMainReason.Rounding = true;
            txtboxMainReason.RoundingInt = 40;
            txtboxMainReason.Size = new Size(216, 35);
            txtboxMainReason.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainReason.TabIndex = 90;
            txtboxMainReason.Tag = "Cyber";
            txtboxMainReason.TextButton = "";
            txtboxMainReason.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainReason.Timer_RGB = 300;
            // 
            // pictureBoxRedStarDelete
            // 
            pictureBoxRedStarDelete.BackgroundImage = Properties.Resources.redstar;
            pictureBoxRedStarDelete.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRedStarDelete.Location = new Point(78, 82);
            pictureBoxRedStarDelete.Name = "pictureBoxRedStarDelete";
            pictureBoxRedStarDelete.Size = new Size(10, 13);
            pictureBoxRedStarDelete.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRedStarDelete.TabIndex = 40;
            pictureBoxRedStarDelete.TabStop = false;
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
            btnCancle.Location = new Point(174, 135);
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
            // panelHeaderDelete
            // 
            panelHeaderDelete.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderDelete.Controls.Add(btnCloseDelete);
            panelHeaderDelete.Controls.Add(lbNameDelete);
            panelHeaderDelete.Location = new Point(0, 0);
            panelHeaderDelete.Name = "panelHeaderDelete";
            panelHeaderDelete.Size = new Size(368, 48);
            panelHeaderDelete.TabIndex = 0;
            // 
            // btnCloseDelete
            // 
            btnCloseDelete.BackgroundImage = Properties.Resources.can_t1;
            btnCloseDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseDelete.FlatAppearance.BorderSize = 0;
            btnCloseDelete.FlatStyle = FlatStyle.Flat;
            btnCloseDelete.Location = new Point(345, 8);
            btnCloseDelete.Name = "btnCloseDelete";
            btnCloseDelete.Size = new Size(15, 14);
            btnCloseDelete.TabIndex = 5;
            btnCloseDelete.UseVisualStyleBackColor = true;
            btnCloseDelete.Click += btnCloseDelete_Click;
            // 
            // lbNameDelete
            // 
            lbNameDelete.AutoSize = true;
            lbNameDelete.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameDelete.ForeColor = Color.White;
            lbNameDelete.Location = new Point(151, 13);
            lbNameDelete.Name = "lbNameDelete";
            lbNameDelete.Size = new Size(62, 22);
            lbNameDelete.TabIndex = 1;
            lbNameDelete.Text = "Delete";
            // 
            // PopUp_Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 190);
            Controls.Add(panelDelete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_Delete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Delete";
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedStarDelete).EndInit();
            panelHeaderDelete.ResumeLayout(false);
            panelHeaderDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDelete;
        private PictureBox pictureBoxRedStarDelete;
        private Label lbNameReason;
        private ReaLTaiizor.Controls.HopeButton btnCancle;
        private ReaLTaiizor.Controls.HopeButton btnSave;
        private Panel panelHeaderDelete;
        private Label lbNameDelete;
        private Button btnCloseDelete;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxReason;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainReason;
    }
}