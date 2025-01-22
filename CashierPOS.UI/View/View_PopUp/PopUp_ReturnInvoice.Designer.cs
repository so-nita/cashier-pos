namespace CashierPOS.UI.View.View_PopUp
{
    partial class PopUp_ReturnInvoice
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
            panelReceipt = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelReceipt
            // 
            panelReceipt.AutoSize = true;
            panelReceipt.Dock = DockStyle.Fill;
            panelReceipt.Location = new Point(0, 0);
            panelReceipt.MinimumSize = new Size(290, 600);
            panelReceipt.Name = "panelReceipt";
            panelReceipt.Size = new Size(290, 600);
            panelReceipt.TabIndex = 0;
            // 
            // PopUp_Recipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(290, 600);
            Controls.Add(panelReceipt);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(290, 600);
            Name = "PopUp_Recipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Recipt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelReceipt;
    }
}