using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_ReprintByInvoiceNo
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
            txtboxInvoiceNo.Enter += CustomStyle.OnMouseHover_Placeholder;
            txtboxInvoiceNo.Leave += CustomStyle.OnMouseLeave_Placeholder;
            CustomStyle.AttachDynamicKeyEvent(txtboxInvoiceNo, txtboxInvoiceNo);

            btnReview.Click += btnReview_Click;
            btnBack.Click += btnBack_Click;
        }
        /// </summary>
        private void InitializeComponent()
        {
            panelReprintByInvoiceNo = new Panel();
            pictureBox1 = new PictureBox();
            txtboxInvoiceNo = new TextBox();
            txtboxMainInvoiceNo = new ReaLTaiizor.Controls.CyberTextBox();
            lbInvoiceNo = new Label();
            btnReview = new ReaLTaiizor.Controls.HopeButton();
            btnBack = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderReprintByInvoiceNo = new Panel();
            btnCloseReprintbyNo = new Button();
            lbNameReprintByInvoiceNo = new Label();
            panelReprintByInvoiceNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeaderReprintByInvoiceNo.SuspendLayout();
            SuspendLayout();
            // 
            // panelReprintByInvoiceNo
            // 
            panelReprintByInvoiceNo.BackColor = Color.FromArgb(176, 215, 181);
            panelReprintByInvoiceNo.Controls.Add(pictureBox1);
            panelReprintByInvoiceNo.Controls.Add(txtboxInvoiceNo);
            panelReprintByInvoiceNo.Controls.Add(txtboxMainInvoiceNo);
            panelReprintByInvoiceNo.Controls.Add(lbInvoiceNo);
            panelReprintByInvoiceNo.Controls.Add(btnReview);
            panelReprintByInvoiceNo.Controls.Add(btnBack);
            panelReprintByInvoiceNo.Controls.Add(panelHeaderReprintByInvoiceNo);
            panelReprintByInvoiceNo.Dock = DockStyle.Fill;
            panelReprintByInvoiceNo.Location = new Point(0, 0);
            panelReprintByInvoiceNo.Name = "panelReprintByInvoiceNo";
            panelReprintByInvoiceNo.Size = new Size(380, 190);
            panelReprintByInvoiceNo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.redstar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(106, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 13);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // txtboxInvoiceNo
            // 
            txtboxInvoiceNo.BackColor = Color.White;
            txtboxInvoiceNo.BorderStyle = BorderStyle.None;
            txtboxInvoiceNo.Font = new Font("Times New Roman", 11.25F);
            txtboxInvoiceNo.ForeColor = Color.Black;
            txtboxInvoiceNo.Location = new Point(142, 80);
            txtboxInvoiceNo.Name = "txtboxInvoiceNo";
            txtboxInvoiceNo.Size = new Size(200, 18);
            txtboxInvoiceNo.TabIndex = 24;
            txtboxInvoiceNo.Tag = " Scan or input";
            // 
            // txtboxMainInvoiceNo
            // 
            txtboxMainInvoiceNo.Alpha = 20;
            txtboxMainInvoiceNo.BackColor = Color.Transparent;
            txtboxMainInvoiceNo.Background_WidthPen = 1F;
            txtboxMainInvoiceNo.BackgroundPen = true;
            txtboxMainInvoiceNo.ColorBackground = Color.White;
            txtboxMainInvoiceNo.ColorBackground_Pen = Color.White;
            txtboxMainInvoiceNo.ColorLighting = Color.White;
            txtboxMainInvoiceNo.ColorPen_1 = Color.White;
            txtboxMainInvoiceNo.ColorPen_2 = Color.White;
            txtboxMainInvoiceNo.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtboxMainInvoiceNo.Font = new Font("Arial", 8F);
            txtboxMainInvoiceNo.ForeColor = Color.FromArgb(245, 245, 245);
            txtboxMainInvoiceNo.Lighting = false;
            txtboxMainInvoiceNo.LinearGradientPen = false;
            txtboxMainInvoiceNo.Location = new Point(130, 70);
            txtboxMainInvoiceNo.Name = "txtboxMainInvoiceNo";
            txtboxMainInvoiceNo.PenWidth = 15;
            txtboxMainInvoiceNo.RGB = false;
            txtboxMainInvoiceNo.Rounding = true;
            txtboxMainInvoiceNo.RoundingInt = 40;
            txtboxMainInvoiceNo.Size = new Size(220, 35);
            txtboxMainInvoiceNo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtboxMainInvoiceNo.TabIndex = 23;
            txtboxMainInvoiceNo.Tag = "Cyber";
            txtboxMainInvoiceNo.TextButton = "";
            txtboxMainInvoiceNo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtboxMainInvoiceNo.Timer_RGB = 300;
            // 
            // lbInvoiceNo
            // 
            lbInvoiceNo.AutoSize = true;
            lbInvoiceNo.Font = new Font("Times New Roman", 12F);
            lbInvoiceNo.ForeColor = SystemColors.WindowText;
            lbInvoiceNo.Location = new Point(29, 78);
            lbInvoiceNo.Name = "lbInvoiceNo";
            lbInvoiceNo.Size = new Size(72, 19);
            lbInvoiceNo.TabIndex = 22;
            lbInvoiceNo.Text = "Invoice №";
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.FromArgb(176, 215, 181);
            btnReview.BorderColor = Color.FromArgb(220, 223, 230);
            btnReview.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnReview.Cursor = Cursors.Hand;
            btnReview.DangerColor = Color.FromArgb(245, 108, 108);
            btnReview.DefaultColor = Color.FromArgb(255, 255, 255);
            btnReview.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnReview.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnReview.InfoColor = Color.FromArgb(144, 147, 153);
            btnReview.Location = new Point(270, 135);
            btnReview.Name = "btnReview";
            btnReview.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnReview.Size = new Size(80, 32);
            btnReview.SuccessColor = Color.FromArgb(103, 194, 58);
            btnReview.TabIndex = 21;
            btnReview.Text = "Review";
            btnReview.TextColor = Color.White;
            btnReview.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnBack
            // 
            btnBack.BorderColor = Color.FromArgb(220, 223, 230);
            btnBack.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnBack.Cursor = Cursors.Hand;
            btnBack.DangerColor = Color.FromArgb(245, 108, 108);
            btnBack.DefaultColor = Color.FromArgb(255, 255, 255);
            btnBack.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnBack.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnBack.InfoColor = Color.FromArgb(144, 147, 153);
            btnBack.Location = new Point(177, 135);
            btnBack.Name = "btnBack";
            btnBack.PrimaryColor = Color.Red;
            btnBack.Size = new Size(80, 32);
            btnBack.SuccessColor = Color.FromArgb(103, 194, 58);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.White;
            btnBack.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // panelHeaderReprintByInvoiceNo
            // 
            panelHeaderReprintByInvoiceNo.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderReprintByInvoiceNo.Controls.Add(btnCloseReprintbyNo);
            panelHeaderReprintByInvoiceNo.Controls.Add(lbNameReprintByInvoiceNo);
            panelHeaderReprintByInvoiceNo.Dock = DockStyle.Top;
            panelHeaderReprintByInvoiceNo.Location = new Point(0, 0);
            panelHeaderReprintByInvoiceNo.Name = "panelHeaderReprintByInvoiceNo";
            panelHeaderReprintByInvoiceNo.Size = new Size(380, 48);
            panelHeaderReprintByInvoiceNo.TabIndex = 0;
            // 
            // btnCloseReprintbyNo
            // 
            btnCloseReprintbyNo.BackgroundImage = Properties.Resources.can_t1;
            btnCloseReprintbyNo.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseReprintbyNo.Cursor = Cursors.Hand;
            btnCloseReprintbyNo.FlatAppearance.BorderSize = 0;
            btnCloseReprintbyNo.FlatStyle = FlatStyle.Flat;
            btnCloseReprintbyNo.Location = new Point(353, 7);
            btnCloseReprintbyNo.Name = "btnCloseReprintbyNo";
            btnCloseReprintbyNo.Size = new Size(22, 22);
            btnCloseReprintbyNo.TabIndex = 8;
            btnCloseReprintbyNo.UseVisualStyleBackColor = true;
            btnCloseReprintbyNo.Click += btnCloseReprintbyNo_Click;
            // 
            // lbNameReprintByInvoiceNo
            // 
            lbNameReprintByInvoiceNo.AutoSize = true;
            lbNameReprintByInvoiceNo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameReprintByInvoiceNo.ForeColor = Color.White;
            lbNameReprintByInvoiceNo.Location = new Point(113, 9);
            lbNameReprintByInvoiceNo.Name = "lbNameReprintByInvoiceNo";
            lbNameReprintByInvoiceNo.Size = new Size(184, 22);
            lbNameReprintByInvoiceNo.TabIndex = 1;
            lbNameReprintByInvoiceNo.Text = "Reprint by Invoice №";
            // 
            // PopUp_ReprintByInvoiceNo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 190);
            Controls.Add(panelReprintByInvoiceNo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_ReprintByInvoiceNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_ReprintByNo";
            Load += InitailizeLoad_Component;
            panelReprintByInvoiceNo.ResumeLayout(false);
            panelReprintByInvoiceNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeaderReprintByInvoiceNo.ResumeLayout(false);
            panelHeaderReprintByInvoiceNo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReprintByInvoiceNo;
        private Panel panelHeaderReprintByInvoiceNo;
        private Label lbNameReprintByInvoiceNo;
        private ReaLTaiizor.Controls.HopeButton btnReview;
        private ReaLTaiizor.Controls.HopeButton btnBack;
        private Label lbInvoiceNo;
        private ReaLTaiizor.Controls.CyberTextBox txtboxMainInvoiceNo;
        private PictureBox pictureBox1;
        private TextBox txtboxInvoiceNo;
        private Button btnCloseReprintbyNo;
    }
}