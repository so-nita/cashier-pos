namespace CashierPOS.UI.View_PopUp
{
    partial class PopUp_ReprintInvoice
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
        private void InitializeComponentData()
        {
            btnReprintByLast.Click += btnReprintByLast_Click;
            btnReprintByInvoice.Click += btnReprintByInvoice_Click;
            btnCloseReprint.Click += btnCloseReprint_Click;
        }
        private void InitializeComponent()
        {
            panelReprintForm = new Panel();
            btnReprintByInvoice = new ReaLTaiizor.Controls.HopeButton();
            btnReprintByLast = new ReaLTaiizor.Controls.HopeButton();
            panelHeaderReprint = new Panel();
            btnCloseReprint = new Button();
            lbNameReprintInvoice = new Label();
            panelReprintForm.SuspendLayout();
            panelHeaderReprint.SuspendLayout();
            SuspendLayout();
            // 
            // panelReprintForm
            // 
            panelReprintForm.BackColor = Color.FromArgb(176, 215, 181);
            panelReprintForm.Controls.Add(btnReprintByInvoice);
            panelReprintForm.Controls.Add(btnReprintByLast);
            panelReprintForm.Controls.Add(panelHeaderReprint);
            panelReprintForm.Location = new Point(0, 0);
            panelReprintForm.Name = "panelReprintForm";
            panelReprintForm.Size = new Size(380, 175);
            panelReprintForm.TabIndex = 1;
            // 
            // btnReprintByInvoice
            // 
            btnReprintByInvoice.BackColor = Color.FromArgb(176, 215, 181);
            btnReprintByInvoice.BorderColor = Color.FromArgb(220, 223, 230);
            btnReprintByInvoice.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnReprintByInvoice.Cursor = Cursors.Hand;
            btnReprintByInvoice.DangerColor = Color.FromArgb(245, 108, 108);
            btnReprintByInvoice.DefaultColor = Color.FromArgb(255, 255, 255);
            btnReprintByInvoice.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnReprintByInvoice.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnReprintByInvoice.InfoColor = Color.FromArgb(144, 147, 153);
            btnReprintByInvoice.Location = new Point(195, 90);
            btnReprintByInvoice.Name = "btnReprintByInvoice";
            btnReprintByInvoice.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnReprintByInvoice.Size = new Size(162, 38);
            btnReprintByInvoice.SuccessColor = Color.FromArgb(103, 194, 58);
            btnReprintByInvoice.TabIndex = 8;
            btnReprintByInvoice.Text = "Reprint by Invoice №";
            btnReprintByInvoice.TextColor = Color.White;
            btnReprintByInvoice.WarningColor = Color.FromArgb(230, 162, 60);
           
            // 
            // btnReprintByLast
            // 
            btnReprintByLast.BorderColor = Color.Black;
            btnReprintByLast.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnReprintByLast.Cursor = Cursors.Hand;
            btnReprintByLast.DangerColor = Color.FromArgb(245, 108, 108);
            btnReprintByLast.DefaultColor = Color.FromArgb(255, 255, 255);
            btnReprintByLast.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnReprintByLast.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnReprintByLast.InfoColor = Color.FromArgb(144, 147, 153);
            btnReprintByLast.Location = new Point(22, 90);
            btnReprintByLast.Name = "btnReprintByLast";
            btnReprintByLast.PrimaryColor = Color.Red;
            btnReprintByLast.Size = new Size(162, 38);
            btnReprintByLast.SuccessColor = Color.FromArgb(103, 194, 58);
            btnReprintByLast.TabIndex = 7;
            btnReprintByLast.Text = "Reprint by Last";
            btnReprintByLast.TextColor = Color.White;
            btnReprintByLast.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // panelHeaderReprint
            // 
            panelHeaderReprint.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderReprint.Controls.Add(btnCloseReprint);
            panelHeaderReprint.Controls.Add(lbNameReprintInvoice);
            panelHeaderReprint.Location = new Point(0, 0);
            panelHeaderReprint.Name = "panelHeaderReprint";
            panelHeaderReprint.Size = new Size(380, 48);
            panelHeaderReprint.TabIndex = 0;
            // 
            // btnCloseReprint
            // 
            btnCloseReprint.BackgroundImage = Properties.Resources.can_t1;
            btnCloseReprint.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseReprint.Cursor = Cursors.Hand;
            btnCloseReprint.FlatAppearance.BorderSize = 0;
            btnCloseReprint.FlatStyle = FlatStyle.Flat;
            btnCloseReprint.Location = new Point(356, 7);
            btnCloseReprint.Name = "btnCloseReprint";
            btnCloseReprint.Size = new Size(17, 17);
            btnCloseReprint.TabIndex = 8;
            btnCloseReprint.UseVisualStyleBackColor = true;
            // 
            // lbNameReprintInvoice
            // 
            lbNameReprintInvoice.AutoSize = true;
            lbNameReprintInvoice.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameReprintInvoice.ForeColor = Color.White;
            lbNameReprintInvoice.Location = new Point(121, 13);
            lbNameReprintInvoice.Name = "lbNameReprintInvoice";
            lbNameReprintInvoice.Size = new Size(136, 22);
            lbNameReprintInvoice.TabIndex = 1;
            lbNameReprintInvoice.Text = "Reprint Invoice";
            // 
            // PopUp_ReprintInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 175);
            Controls.Add(panelReprintForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_ReprintInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Reprint";
            panelReprintForm.ResumeLayout(false);
            panelHeaderReprint.ResumeLayout(false);
            panelHeaderReprint.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReprintForm;
        private ReaLTaiizor.Controls.HopeButton btnReprintByInvoice;
        private ReaLTaiizor.Controls.HopeButton btnReprintByLast;
        private Panel panelHeaderReprint;
        private Label lbNameReprintInvoice;
        private Button btnCloseReprint;
    }
}