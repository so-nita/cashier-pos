namespace CashierPOS.UI.UserControls
{
    partial class UC_ProductInInvoice
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
            panelProductInvoice = new Panel();
            lbNetPrice = new Label();
            lbPrice = new Label();
            lbQty = new Label();
            lbItemCode = new Label();
            lbItemName = new Label();
            panelProductInvoice.SuspendLayout();
            SuspendLayout();
            // 
            // panelProductInvoice
            // 
            panelProductInvoice.BackColor = Color.White;
            panelProductInvoice.Controls.Add(lbNetPrice);
            panelProductInvoice.Controls.Add(lbPrice);
            panelProductInvoice.Controls.Add(lbQty);
            panelProductInvoice.Controls.Add(lbItemCode);
            panelProductInvoice.Controls.Add(lbItemName);
            panelProductInvoice.Location = new Point(1, 1);
            panelProductInvoice.Name = "panelProductInvoice";
            panelProductInvoice.Size = new Size(296, 23);
            panelProductInvoice.TabIndex = 59;
            // 
            // lbNetPrice
            // 
            lbNetPrice.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNetPrice.Location = new Point(221, 9);
            lbNetPrice.Name = "lbNetPrice";
            lbNetPrice.Size = new Size(52, 13);
            lbNetPrice.TabIndex = 52;
            lbNetPrice.Text = "$43.3333";
            lbNetPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrice.Location = new Point(169, 9);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 14);
            lbPrice.TabIndex = 51;
            lbPrice.Text = "$ 333.33";
            lbPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbQty
            // 
            lbQty.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQty.Location = new Point(148, 9);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(20, 13);
            lbQty.TabIndex = 50;
            lbQty.Text = "1";
            lbQty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbItemCode
            // 
            lbItemCode.Font = new Font("Times New Roman", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemCode.Location = new Point(0, 10);
            lbItemCode.MaximumSize = new Size(160, 24);
            lbItemCode.Name = "lbItemCode";
            lbItemCode.Size = new Size(144, 12);
            lbItemCode.TabIndex = 49;
            lbItemCode.Text = "Exchange";
            // 
            // lbItemName
            // 
            lbItemName.AutoSize = true;
            lbItemName.Font = new Font("Times New Roman", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItemName.ForeColor = SystemColors.ControlDarkDark;
            lbItemName.Location = new Point(1, -2);
            lbItemName.Margin = new Padding(1, 0, 3, 0);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(70, 12);
            lbItemName.TabIndex = 48;
            lbItemName.Text = "9556439882270";
            // 
            // UC_ProductInInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelProductInvoice);
            Name = "UC_ProductInInvoice";
            Size = new Size(298, 24);
            panelProductInvoice.ResumeLayout(false);
            panelProductInvoice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProductInvoice;
        private Label lbNetPrice;
        private Label lbPrice;
        private Label lbQty;
        private Label lbItemCode;
        private Label lbItemName;
    }
}