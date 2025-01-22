namespace CashierPOS.UI.UserControls
{
    partial class UC_ReceiptDiscountSummary
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
            panel_DiscountSummary = new Panel();
            lbValueDisTypeTotal = new Label();
            lbvalueSKUQty = new Label();
            lbvalueDisType = new Label();
            panel_DiscountSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panel_DiscountSummary
            // 
            panel_DiscountSummary.BackColor = Color.White;
            panel_DiscountSummary.Controls.Add(lbValueDisTypeTotal);
            panel_DiscountSummary.Controls.Add(lbvalueSKUQty);
            panel_DiscountSummary.Controls.Add(lbvalueDisType);
            panel_DiscountSummary.Dock = DockStyle.Fill;
            panel_DiscountSummary.Location = new Point(0, 0);
            panel_DiscountSummary.Name = "panel_DiscountSummary";
            panel_DiscountSummary.Size = new Size(293, 11);
            panel_DiscountSummary.TabIndex = 117;
            // 
            // lbValueDisTypeTotal
            // 
            lbValueDisTypeTotal.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbValueDisTypeTotal.Location = new Point(188, -1);
            lbValueDisTypeTotal.Name = "lbValueDisTypeTotal";
            lbValueDisTypeTotal.Size = new Size(80, 11);
            lbValueDisTypeTotal.TabIndex = 121;
            lbValueDisTypeTotal.Text = "$ 300.00";
            lbValueDisTypeTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbvalueSKUQty
            // 
            lbvalueSKUQty.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbvalueSKUQty.Location = new Point(131, -1);
            lbvalueSKUQty.Name = "lbvalueSKUQty";
            lbvalueSKUQty.Size = new Size(54, 11);
            lbvalueSKUQty.TabIndex = 120;
            lbvalueSKUQty.Text = "20";
            lbvalueSKUQty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbvalueDisType
            // 
            lbvalueDisType.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbvalueDisType.Location = new Point(3, -1);
            lbvalueDisType.Margin = new Padding(0, 0, 3, 0);
            lbvalueDisType.Name = "lbvalueDisType";
            lbvalueDisType.Padding = new Padding(14, 0, 0, 0);
            lbvalueDisType.Size = new Size(122, 11);
            lbvalueDisType.TabIndex = 119;
            lbvalueDisType.Text = "10%";
            lbvalueDisType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_ReceiptDiscountSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_DiscountSummary);
            Name = "UC_ReceiptDiscountSummary";
            Size = new Size(293, 11);
            panel_DiscountSummary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_DiscountSummary;
        private Label lbValueDisTypeTotal;
        private Label lbvalueSKUQty;
        private Label lbvalueDisType;
    }
}