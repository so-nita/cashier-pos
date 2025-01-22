namespace CashierPOS.UI.UserControls.ViewStock
{
    partial class UC_ProductStock
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
            lblQty = new Label();
            lblName_item = new Label();
            lbbarcodeItem = new Label();
            pictureItem = new ReaLTaiizor.Controls.HopePictureBox();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            SuspendLayout();
            // 
            // lblQty
            // 
            lblQty.BackColor = Color.White;
            lblQty.Location = new Point(427, 16);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(45, 23);
            lblQty.TabIndex = 1;
            lblQty.Text = "1000";
            lblQty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName_item
            // 
            lblName_item.BackColor = Color.White;
            lblName_item.Location = new Point(80, 7);
            lblName_item.Name = "lblName_item";
            lblName_item.Size = new Size(341, 23);
            lblName_item.TabIndex = 1;
            lblName_item.Text = "Anchor White 330Mlx24'S";
            lblName_item.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbbarcodeItem
            // 
            lbbarcodeItem.BackColor = Color.White;
            lbbarcodeItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbbarcodeItem.Location = new Point(82, 26);
            lbbarcodeItem.Name = "lbbarcodeItem";
            lbbarcodeItem.Size = new Size(341, 25);
            lbbarcodeItem.TabIndex = 3;
            lbbarcodeItem.Text = "101240000012";
            lbbarcodeItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureItem
            // 
            pictureItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureItem.BackColor = Color.Transparent;
            pictureItem.Image = Properties.Resources.Nescafe;
            pictureItem.Location = new Point(5, 5);
            pictureItem.Name = "pictureItem";
            pictureItem.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pictureItem.Size = new Size(55, 47);
            pictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureItem.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            pictureItem.TabIndex = 2;
            pictureItem.TabStop = false;
            pictureItem.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(1, 1);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(473, 52);
            materialCard1.TabIndex = 4;
            // 
            // UC_ListStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureItem);
            Controls.Add(lbbarcodeItem);
            Controls.Add(lblName_item);
            Controls.Add(lblQty);
            Controls.Add(materialCard1);
            Name = "UC_ListStock";
            Size = new Size(475, 54);
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblQty;
        private Label lblName_item;
        private Label lbbarcodeItem;
        private ReaLTaiizor.Controls.HopePictureBox pictureItem;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
    }
}
