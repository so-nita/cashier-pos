namespace CashierPOS.UI.UserControls
{
    partial class UC_ProuductCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        private void InitializeLocation()
        {
            /*pictureItem.Location = new Point(4, 4);
            pictureItem.Size = new Size(188, 153);*/

           /* panelDisocount.Location = new Point(148, 4);
            panelDisocount.Size = new Size(38, 36);*/

            /*labelNameItem.Size = new Size(140, 32);
            labelNameItem.Location = new Point(5, 170);
            labelNameItem.MaximumSize = new Size(120, 30);
            labelNameItem.MinimumSize = new Size(192, 30);*/

            /*labelPriceItem.Location = new Point(5, 208);
            labelPriceItem.Size = new Size(38, 15);*/

            /*labelBarcode.Location = new Point(10, 618);
            labelBarcode.Size = new Size(44, 12);*/

            /*lbbarcodeItem.Location = new Point(5, 229);
            lbbarcodeItem.Size = new Size(85, 13);

            materialCard1.Location = new Point(8, 5);
            materialCard1.Size = new Size(220, 257);*/

            /*lbDiscount.Location = new Point(154, 10);
            lbDiscount.Size = new Size(28, 24);
*/
            /*labelSize.Location = new Point(7, 200);
            labelSize.Size = new Size(25, 12);*/

            /*btn_forBuy.Location = new Point(176, 226);
            btn_forBuy.Size = new Size(36, 22);*/

            /*btnStock.Size = new Size(65, 20);
            btnStock.Location = new Point(148, 201);*/

            /*label1.Location = new Point(50, 208);
            label1.Size = new Size(28, 14);*/

            Size = new Size(209, 270);
        }
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
        //Create style hover for product sell
        private void ProductCard_MouseEnter(object sender, EventArgs e)
        {
            materialCard1.Location = new Point(materialCard1.Location.X, materialCard1.Location.Y - 7);
            materialCard1.BringToFront();
        }
        private void ProductCard_MouseLeave(object sender, EventArgs e)
        {
            materialCard1.Location = new Point(materialCard1.Location.X, materialCard1.Location.Y + 7);
            materialCard1.BringToFront();
        }

        private void InitializeComponentData()
        {
            pictureItem.MouseEnter += ProductCard_MouseEnter;
            pictureItem.MouseLeave += ProductCard_MouseLeave;

        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            panelDisocount = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureItem = new ReaLTaiizor.Controls.HopePictureBox();
            labelNameItem = new Label();
            labelPriceItem = new Label();
            labelBarcode = new Label();
            lbbarcodeItem = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            lbDiscount = new Label();
            btn_forBuy = new ReaLTaiizor.Controls.CyberButton();
            btnStock = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            labelSize = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDisocount
            // 
            panelDisocount.BackColor = Color.FromArgb(16, 107, 67);
            panelDisocount.BorderColor = Color.Transparent;
            panelDisocount.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            panelDisocount.DangerColor = Color.Transparent;
            panelDisocount.DefaultColor = Color.Transparent;
            panelDisocount.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelDisocount.ForeColor = Color.White;
            panelDisocount.HoverTextColor = Color.FromArgb(16, 107, 67);
            panelDisocount.InfoColor = Color.FromArgb(16, 107, 67);
            panelDisocount.Location = new Point(160, 4);
            panelDisocount.Name = "panelDisocount";
            panelDisocount.PrimaryColor = Color.FromArgb(16, 107, 67);
            panelDisocount.Size = new Size(38, 36);
            panelDisocount.SuccessColor = Color.FromArgb(16, 107, 67);
            panelDisocount.TabIndex = 21;
            panelDisocount.TextColor = Color.Black;
            panelDisocount.Visible = false;
            panelDisocount.WarningColor = Color.FromArgb(16, 107, 67);
            // 
            // pictureItem
            // 
            pictureItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureItem.BackColor = Color.Transparent;
            pictureItem.Location = new Point(4, 2);
            pictureItem.Name = "pictureItem";
            pictureItem.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pictureItem.Size = new Size(212, 158);
            pictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureItem.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            pictureItem.TabIndex = 0;
            pictureItem.TabStop = false;
            pictureItem.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // labelNameItem
            // 
            labelNameItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNameItem.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameItem.Location = new Point(5, 154);
            labelNameItem.MaximumSize = new Size(120, 30);
            labelNameItem.MinimumSize = new Size(192, 30);
            labelNameItem.Name = "labelNameItem";
            labelNameItem.Size = new Size(192, 30);
            labelNameItem.TabIndex = 1;
            labelNameItem.Text = "NECAFE NECAFE fdfdfdfd hhhhhhhhh";
            labelNameItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPriceItem
            // 
            labelPriceItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPriceItem.AutoSize = true;
            labelPriceItem.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPriceItem.ForeColor = Color.FromArgb(16, 107, 67);
            labelPriceItem.Location = new Point(5, 210);
            labelPriceItem.Name = "labelPriceItem";
            labelPriceItem.Size = new Size(59, 15);
            labelPriceItem.TabIndex = 1;
            labelPriceItem.Text = "$48.2500";
            // 
            // labelBarcode
            // 
            labelBarcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelBarcode.AutoSize = true;
            labelBarcode.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBarcode.ForeColor = Color.FromArgb(70, 84, 69);
            labelBarcode.Location = new Point(5, 238);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(44, 12);
            labelBarcode.TabIndex = 1;
            labelBarcode.Text = "Barcode :";
            // 
            // lbbarcodeItem
            // 
            lbbarcodeItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbbarcodeItem.AutoSize = true;
            lbbarcodeItem.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbbarcodeItem.ForeColor = Color.FromArgb(70, 84, 69);
            lbbarcodeItem.Location = new Point(55, 238);
            lbbarcodeItem.Name = "lbbarcodeItem";
            lbbarcodeItem.Size = new Size(85, 13);
            lbbarcodeItem.TabIndex = 1;
            lbbarcodeItem.Text = "8850127004397";
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lbDiscount);
            materialCard1.Controls.Add(panelDisocount);
            materialCard1.Controls.Add(btn_forBuy);
            materialCard1.Controls.Add(btnStock);
            materialCard1.Controls.Add(lbbarcodeItem);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(labelSize);
            materialCard1.Controls.Add(labelBarcode);
            materialCard1.Controls.Add(labelPriceItem);
            materialCard1.Controls.Add(labelNameItem);
            materialCard1.Controls.Add(pictureItem);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(5, 5);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(220, 263);
            materialCard1.TabIndex = 0;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.BackColor = Color.FromArgb(16, 107, 67);
            lbDiscount.Font = new Font("Times New Roman", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiscount.ForeColor = Color.White;
            lbDiscount.Location = new Point(165, 10);
            lbDiscount.MaximumSize = new Size(28, 40);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(28, 24);
            lbDiscount.TabIndex = 24;
            lbDiscount.Text = "10 % Off";
            lbDiscount.Visible = false;
            // 
            // btn_forBuy
            // 
            btn_forBuy.Alpha = 20;
            btn_forBuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_forBuy.BackColor = Color.Transparent;
            btn_forBuy.Background = true;
            btn_forBuy.Background_WidthPen = 2F;
            btn_forBuy.BackgroundPen = true;
            btn_forBuy.ColorBackground = Color.White;
            btn_forBuy.ColorBackground_1 = Color.FromArgb(41, 63, 86);
            btn_forBuy.ColorBackground_2 = Color.Blue;
            btn_forBuy.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn_forBuy.ColorLighting = Color.Blue;
            btn_forBuy.ColorPen_1 = Color.Blue;
            btn_forBuy.ColorPen_2 = Color.FromArgb(255, 128, 0);
            btn_forBuy.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn_forBuy.Effect_1 = true;
            btn_forBuy.Effect_1_ColorBackground = Color.Blue;
            btn_forBuy.Effect_1_Transparency = 20;
            btn_forBuy.Effect_2 = true;
            btn_forBuy.Effect_2_ColorBackground = Color.FromArgb(56, 56, 56);
            btn_forBuy.Effect_2_Transparency = 20;
            btn_forBuy.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_forBuy.ForeColor = Color.FromArgb(16, 107, 67);
            btn_forBuy.Lighting = false;
            btn_forBuy.LinearGradient_Background = false;
            btn_forBuy.LinearGradientPen = false;
            btn_forBuy.Location = new Point(170, 234);
            btn_forBuy.Name = "btn_forBuy";
            btn_forBuy.PenWidth = 15;
            btn_forBuy.Rounding = true;
            btn_forBuy.RoundingInt = 70;
            btn_forBuy.Size = new Size(40, 22);
            btn_forBuy.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_forBuy.TabIndex = 20;
            btn_forBuy.Tag = "Cyber";
            btn_forBuy.TextButton = "Buy";
            btn_forBuy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn_forBuy.Timer_Effect_1 = 1;
            btn_forBuy.Timer_RGB = 1;
            // 
            // btnStock
            // 
            btnStock.Alpha = 20;
            btnStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStock.BackColor = Color.Transparent;
            btnStock.Background = true;
            btnStock.Background_WidthPen = 1F;
            btnStock.BackgroundPen = true;
            btnStock.ColorBackground = Color.Red;
            btnStock.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnStock.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnStock.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnStock.ColorLighting = Color.FromArgb(29, 200, 238);
            btnStock.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnStock.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnStock.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnStock.Effect_1 = true;
            btnStock.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnStock.Effect_1_Transparency = 25;
            btnStock.Effect_2 = true;
            btnStock.Effect_2_ColorBackground = Color.White;
            btnStock.Effect_2_Transparency = 20;
            btnStock.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStock.ForeColor = Color.White;
            btnStock.Lighting = false;
            btnStock.LinearGradient_Background = false;
            btnStock.LinearGradientPen = false;
            btnStock.Location = new Point(150, 200);
            btnStock.Name = "btnStock";
            btnStock.PenWidth = 20;
            btnStock.Rounding = true;
            btnStock.RoundingInt = 70;
            btnStock.Size = new Size(65, 20);
            btnStock.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStock.TabIndex = 23;
            btnStock.Tag = "Cyber";
            btnStock.TextButton = "Out Stock";
            btnStock.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStock.Timer_Effect_1 = 5;
            btnStock.Timer_RGB = 300;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 107, 67);
            label1.Location = new Point(60, 211);
            label1.Name = "label1";
            label1.Size = new Size(28, 14);
            label1.TabIndex = 1;
            label1.Text = "each";
            // 
            // labelSize
            // 
            labelSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSize.ForeColor = Color.FromArgb(70, 84, 69);
            labelSize.Location = new Point(6, 199);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(25, 12);
            labelSize.TabIndex = 1;
            labelSize.Text = "200g";
            // 
            // UC_ProuductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Margin = new Padding(4, 5, 3, 3);
            Name = "UC_ProuductCard";
            Size = new Size(230, 275);
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #region On Mouse hover product card
        private void UC_ProuductCard_MouseHover(object sender, EventArgs e)
        {
            // Scale down the UserControl
            this.Size = new Size(220, 250);
        }
        private void UC_ProuductCard_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(164, 210);
        }
        #endregion

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private ReaLTaiizor.Controls.HopePictureBox pictureItem;
        private Label labelNameItem;
        private Label labelPriceItem;
        private Label labelBarcode;
        private Label lbbarcodeItem;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label labelSize;
        private Label label1;
        private Label labelStock;
        private ReaLTaiizor.Controls.CyberButton btnStock;
        private ReaLTaiizor.Controls.CyberButton btn_forBuy;
        private ReaLTaiizor.Controls.HopeRoundButton panelDisocount;
        private Label lbDiscount;
    }
}