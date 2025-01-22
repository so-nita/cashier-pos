
namespace CashierPOS.UI.UserControls
{
    partial class UC_PaymentMethod
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paymentCard = new ReaLTaiizor.Controls.MaterialCard();
            lbPaymentName = new Label();
            lbPaymentImg = new ReaLTaiizor.Controls.HopePictureBox();
            paymentCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbPaymentImg).BeginInit();
            SuspendLayout();
            // 
            // paymentCard
            // 
            paymentCard.BackColor = Color.FromArgb(255, 255, 255);
            paymentCard.Controls.Add(lbPaymentName);
            paymentCard.Controls.Add(lbPaymentImg);
            paymentCard.Cursor = Cursors.Hand;
            paymentCard.Depth = 0;
            paymentCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            paymentCard.Location = new Point(8, 4);
            paymentCard.Margin = new Padding(0);
            paymentCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            paymentCard.Name = "paymentCard";
            paymentCard.Padding = new Padding(2);
            paymentCard.Size = new Size(100, 100);
            paymentCard.TabIndex = 0;
            // 
            // lbPaymentName
            // 
            lbPaymentName.Dock = DockStyle.Bottom;
            lbPaymentName.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPaymentName.Location = new Point(2, 78);
            lbPaymentName.Name = "lbPaymentName";
            lbPaymentName.Size = new Size(96, 20);
            lbPaymentName.TabIndex = 4;
            lbPaymentName.Text = "ABA ";
            lbPaymentName.TextAlign = ContentAlignment.MiddleCenter;
            lbPaymentName.Click += lbPaymentName_Click;
            // 
            // lbPaymentImg
            // 
            lbPaymentImg.BackColor = Color.Transparent;
            lbPaymentImg.BackgroundImage = Properties.Resources.AC_logo;
            lbPaymentImg.BackgroundImageLayout = ImageLayout.Zoom;
            lbPaymentImg.ErrorImage = null;
            lbPaymentImg.Image = Properties.Resources.aba_logo1;
            lbPaymentImg.Location = new Point(2, 2);
            lbPaymentImg.Margin = new Padding(3, 0, 3, 3);
            lbPaymentImg.Name = "lbPaymentImg";
            lbPaymentImg.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            lbPaymentImg.Size = new Size(96, 70);
            lbPaymentImg.SizeMode = PictureBoxSizeMode.Zoom;
            lbPaymentImg.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            lbPaymentImg.TabIndex = 3;
            lbPaymentImg.TabStop = false;
            lbPaymentImg.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            lbPaymentImg.Click += lbPaymentImg_Click;
            // 
            // UC_PaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(paymentCard);
            Margin = new Padding(0, 3, 3, 3);
            Name = "UC_PaymentMethod";
            Size = new Size(116, 110);
            paymentCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lbPaymentImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard paymentCard;
        public Label lbPaymentName;
        public ReaLTaiizor.Controls.HopePictureBox lbPaymentImg;
    }
}
