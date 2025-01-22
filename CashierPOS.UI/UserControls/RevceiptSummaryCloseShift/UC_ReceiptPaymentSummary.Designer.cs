namespace CashierPOS.UI.UserControls
{
    partial class UC_ReceiptPaymentSummary
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
            panel_paymentSummary = new Panel();
            lbTotal = new Label();
            lbQty = new Label();
            lbPaymentType = new Label();
            panel_paymentSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panel_paymentSummary
            // 
            panel_paymentSummary.BackColor = Color.White;
            panel_paymentSummary.Controls.Add(lbTotal);
            panel_paymentSummary.Controls.Add(lbQty);
            panel_paymentSummary.Controls.Add(lbPaymentType);
            panel_paymentSummary.Dock = DockStyle.Fill;
            panel_paymentSummary.Location = new Point(0, 0);
            panel_paymentSummary.Name = "panel_paymentSummary";
            panel_paymentSummary.Size = new Size(292, 20);
            panel_paymentSummary.TabIndex = 116;
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(185, 3);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(80, 15);
            lbTotal.TabIndex = 121;
            lbTotal.Text = "$ 300.00";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbQty
            // 
            lbQty.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQty.Location = new Point(138, 3);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(30, 15);
            lbQty.TabIndex = 120;
            lbQty.Text = "2000";
            lbQty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPaymentType
            // 
            lbPaymentType.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPaymentType.Location = new Point(2, 3);
            lbPaymentType.Name = "lbPaymentType";
            lbPaymentType.Size = new Size(121, 15);
            lbPaymentType.TabIndex = 119;
            lbPaymentType.Text = "RED ANT EXPRESS";
            lbPaymentType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_ReceiptPaymentSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_paymentSummary);
            Name = "UC_ReceiptPaymentSummary";
            Size = new Size(292, 20);
            panel_paymentSummary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_paymentSummary;
        private Label lbTotal;
        private Label lbQty;
        private Label lbPaymentType;
    }
}