
using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.View.View_PopUp
{
    partial class PopUp_HoldOrder
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
            panelHeaderCloseShift = new Panel();
            btnCloseDelete = new Button();
            lbNameCloseShift = new Label();
            panelHoldOrder = new FlowLayoutPanel();
            labelTotal = new Label();
            panelListHoldOrder = new FlowLayoutPanel();
            panelHeaderCloseShift.SuspendLayout();
            panelHoldOrder.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeaderCloseShift
            // 
            panelHeaderCloseShift.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderCloseShift.Controls.Add(btnCloseDelete);
            panelHeaderCloseShift.Controls.Add(lbNameCloseShift);
            panelHeaderCloseShift.Dock = DockStyle.Top;
            panelHeaderCloseShift.Location = new Point(0, 0);
            panelHeaderCloseShift.Name = "panelHeaderCloseShift";
            panelHeaderCloseShift.Size = new Size(480, 48);
            panelHeaderCloseShift.TabIndex = 0;
            // 
            // btnCloseDelete
            // 
            btnCloseDelete.BackgroundImage = Properties.Resources.can_t1;
            btnCloseDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseDelete.FlatAppearance.BorderSize = 0;
            btnCloseDelete.FlatStyle = FlatStyle.Flat;
            btnCloseDelete.Location = new Point(458, 7);
            btnCloseDelete.Name = "btnCloseDelete";
            btnCloseDelete.Size = new Size(15, 14);
            btnCloseDelete.TabIndex = 13;
            btnCloseDelete.UseVisualStyleBackColor = true;
            btnCloseDelete.Click += btnCloseDelete_Click;
            // 
            // lbNameCloseShift
            // 
            lbNameCloseShift.AutoSize = true;
            lbNameCloseShift.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbNameCloseShift.ForeColor = Color.White;
            lbNameCloseShift.Location = new Point(185, 13);
            lbNameCloseShift.Name = "lbNameCloseShift";
            lbNameCloseShift.Size = new Size(109, 22);
            lbNameCloseShift.TabIndex = 1;
            lbNameCloseShift.Text = "Hold Order ";
            // 
            // panelHoldOrder
            // 
            panelHoldOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHoldOrder.AutoSize = true;
            panelHoldOrder.BackColor = Color.FromArgb(176, 215, 181);
            panelHoldOrder.Controls.Add(labelTotal);
            panelHoldOrder.Controls.Add(panelListHoldOrder);
            panelHoldOrder.Location = new Point(0, 48);
            panelHoldOrder.Name = "panelHoldOrder";
            panelHoldOrder.Padding = new Padding(3, 0, 0, 20);
            panelHoldOrder.Size = new Size(480, 412);
            panelHoldOrder.TabIndex = 2;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(6, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Padding = new Padding(0, 5, 0, 0);
            labelTotal.Size = new Size(470, 12);
            labelTotal.TabIndex = 22;
            labelTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelListHoldOrder
            // 
            panelListHoldOrder.Anchor = AnchorStyles.Left;
            panelListHoldOrder.AutoScroll = true;
            panelListHoldOrder.AutoSize = true;
            panelListHoldOrder.BackColor = Color.Transparent;
            panelListHoldOrder.Cursor = Cursors.Hand;
            panelListHoldOrder.FlowDirection = FlowDirection.TopDown;
            panelListHoldOrder.Location = new Point(6, 15);
            panelListHoldOrder.MaximumSize = new Size(470, 645);
            panelListHoldOrder.MinimumSize = new Size(470, 352);
            panelListHoldOrder.Name = "panelListHoldOrder";
            panelListHoldOrder.Padding = new Padding(5, 0, 10, 0);
            panelListHoldOrder.Size = new Size(470, 352);
            panelListHoldOrder.TabIndex = 23;
            panelListHoldOrder.WrapContents = false;
            // 
            // PopUp_HoldOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(480, 460);
            Controls.Add(panelHoldOrder);
            Controls.Add(panelHeaderCloseShift);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(480, 720);
            MinimumSize = new Size(480, 460);
            Name = "PopUp_HoldOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp_Close";
            Load += InitailizeLoad_Component;
            panelHeaderCloseShift.ResumeLayout(false);
            panelHeaderCloseShift.PerformLayout();
            panelHoldOrder.ResumeLayout(false);
            panelHoldOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelHeaderCloseShift;
        private Label lbNameCloseShift;
        private FlowLayoutPanel panelHoldOrder;
        private FlowLayoutPanel panelListHoldOrder;
        private Button btnCloseDelete;
        private Label labelTotal;
    }
}