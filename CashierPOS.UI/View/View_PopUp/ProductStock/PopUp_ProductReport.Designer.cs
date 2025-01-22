namespace CashierPOS.UI.View.View_PopUp.ProductStock
{
    partial class PopUp_ProductReport
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
            panel_ProductReport = new Panel();
            SuspendLayout();
            // 
            // panel_ProductReport
            // 
            panel_ProductReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ProductReport.BackColor = Color.White;
            panel_ProductReport.Location = new Point(0, 0);
            panel_ProductReport.Name = "panel_ProductReport";
            panel_ProductReport.Size = new Size(800, 463);
            panel_ProductReport.TabIndex = 0;
            // 
            // PopUp_ProductReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(panel_ProductReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_ProductReport";
            Text = "PopUp_ProductReport";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ProductReport;
    }
}