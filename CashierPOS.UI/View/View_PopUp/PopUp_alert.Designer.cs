namespace CashierPOS.UI.View.View_PopUp
{
    partial class PopUp_alert
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
            panelAlert = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            btnCash = new ReaLTaiizor.Controls.HopeButton();
            btnCreditCard = new ReaLTaiizor.Controls.HopeButton();
            pictureBoxDont = new PictureBox();
            lbNameAreYouSure = new Label();
            panelAlert.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDont).BeginInit();
            SuspendLayout();
            // 
            // panelAlert
            // 
            panelAlert.BackColor = Color.White;
            panelAlert.Controls.Add(button1);
            panelAlert.Controls.Add(panel1);
            panelAlert.Controls.Add(pictureBoxDont);
            panelAlert.Controls.Add(lbNameAreYouSure);
            panelAlert.Location = new Point(0, 0);
            panelAlert.Name = "panelAlert";
            panelAlert.Size = new Size(380, 175);
            panelAlert.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(354, 5);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 37;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnCash);
            panel1.Controls.Add(btnCreditCard);
            panel1.Location = new Point(0, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 59);
            panel1.TabIndex = 40;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.FromArgb(176, 215, 181);
            btnCash.BorderColor = Color.FromArgb(220, 223, 230);
            btnCash.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCash.DangerColor = Color.FromArgb(245, 108, 108);
            btnCash.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCash.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCash.ForeColor = SystemColors.WindowText;
            btnCash.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCash.InfoColor = Color.FromArgb(144, 147, 153);
            btnCash.Location = new Point(199, 13);
            btnCash.Name = "btnCash";
            btnCash.PrimaryColor = Color.DodgerBlue;
            btnCash.Size = new Size(110, 33);
            btnCash.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCash.TabIndex = 35;
            btnCash.Text = "Cash ";
            btnCash.TextColor = Color.Black;
            btnCash.WarningColor = Color.FromArgb(230, 162, 60);
            btnCash.Click += btnCash_Click;
            // 
            // btnCreditCard
            // 
            btnCreditCard.BackColor = Color.FromArgb(176, 215, 181);
            btnCreditCard.BorderColor = Color.FromArgb(220, 223, 230);
            btnCreditCard.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCreditCard.DangerColor = Color.FromArgb(245, 108, 108);
            btnCreditCard.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCreditCard.Enabled = false;
            btnCreditCard.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCreditCard.ForeColor = SystemColors.WindowText;
            btnCreditCard.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCreditCard.InfoColor = Color.FromArgb(144, 147, 153);
            btnCreditCard.Location = new Point(80, 13);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.PrimaryColor = Color.DodgerBlue;
            btnCreditCard.Size = new Size(110, 33);
            btnCreditCard.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCreditCard.TabIndex = 36;
            btnCreditCard.Text = "Credit Card";
            btnCreditCard.TextColor = Color.DimGray;
            btnCreditCard.WarningColor = Color.FromArgb(230, 162, 60);
            btnCreditCard.Click += btnCreditCard_Click;
            // 
            // pictureBoxDont
            // 
            pictureBoxDont.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxDont.Location = new Point(27, 52);
            pictureBoxDont.Name = "pictureBoxDont";
            pictureBoxDont.Size = new Size(35, 25);
            pictureBoxDont.TabIndex = 38;
            pictureBoxDont.TabStop = false;
            // 
            // lbNameAreYouSure
            // 
            lbNameAreYouSure.AutoSize = true;
            lbNameAreYouSure.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameAreYouSure.ForeColor = SystemColors.WindowText;
            lbNameAreYouSure.Location = new Point(62, 56);
            lbNameAreYouSure.Name = "lbNameAreYouSure";
            lbNameAreYouSure.Size = new Size(283, 19);
            lbNameAreYouSure.TabIndex = 10;
            lbNameAreYouSure.Text = "Please choose payment Cash or Credit Card.";
            // 
            // PopUp_alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 175);
            Controls.Add(panelAlert);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_alert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_alert";
            panelAlert.ResumeLayout(false);
            panelAlert.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDont).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAlert;
        private Label lbNameAreYouSure;
        private ReaLTaiizor.Controls.HopeButton btnCash;
        private ReaLTaiizor.Controls.HopeButton btnCreditCard;
        private Button button1;
        private PictureBox pictureBoxDont;
        private Panel panel1;
    }
}