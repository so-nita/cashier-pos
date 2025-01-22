using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.UI.UserControls
{
    partial class UC_ProuductForCart
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
        private void InitializeComponentData()
        {
            if (IsReturnOrder)
            {
                txtProductQty.Enabled = false;
            }
            txtProductQty.MaxLength = 3;
        }
        private void InitializeComponent()
        {
            panelCard = new ReaLTaiizor.Controls.MaterialCard();
            lbSubTotalPrice = new Label();
            txtProductQty = new TextBox();
            btnAdd = new Button();
            btnSubstract = new Button();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            btndelete = new Button();
            lbSubTotalPriceKh = new Label();
            lbGrandTotalPrice = new Label();
            lablePrice = new Label();
            labelbarcode = new Label();
            label3 = new Label();
            lbSize = new Label();
            label1 = new Label();
            lbDiscountAmount = new Label();
            label4 = new Label();
            lableName = new Label();
            picProduct = new ReaLTaiizor.Controls.HopePictureBox();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.FromArgb(255, 255, 255);
            panelCard.Controls.Add(lbSubTotalPrice);
            panelCard.Controls.Add(txtProductQty);
            panelCard.Controls.Add(btnAdd);
            panelCard.Controls.Add(btnSubstract);
            panelCard.Controls.Add(cyberButton1);
            panelCard.Controls.Add(btndelete);
            panelCard.Controls.Add(lbSubTotalPriceKh);
            panelCard.Controls.Add(lbGrandTotalPrice);
            panelCard.Controls.Add(lablePrice);
            panelCard.Controls.Add(labelbarcode);
            panelCard.Controls.Add(label3);
            panelCard.Controls.Add(lbSize);
            panelCard.Controls.Add(label1);
            panelCard.Controls.Add(lbDiscountAmount);
            panelCard.Controls.Add(label4);
            panelCard.Controls.Add(lableName);
            panelCard.Controls.Add(picProduct);
            panelCard.Depth = 0;
            panelCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelCard.Location = new Point(1, 1);
            panelCard.Margin = new Padding(14);
            panelCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(14);
            panelCard.Size = new Size(360, 70);
            panelCard.TabIndex = 0;
            // 
            // lbSubTotalPrice
            // 
            lbSubTotalPrice.Font = new Font("Times New Roman", 7F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            lbSubTotalPrice.ForeColor = Color.FromArgb(16, 107, 67);
            lbSubTotalPrice.Location = new Point(253, 37);
            lbSubTotalPrice.Margin = new Padding(0);
            lbSubTotalPrice.Name = "lbSubTotalPrice";
            lbSubTotalPrice.Size = new Size(45, 12);
            lbSubTotalPrice.TabIndex = 19;
            lbSubTotalPrice.Text = "$ 41.25";
            lbSubTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            lbSubTotalPrice.Visible = false;
            // 
            // txtProductQty
            // 
            txtProductQty.BackColor = Color.White;
            txtProductQty.BorderStyle = BorderStyle.None;
            txtProductQty.Font = new Font("Times New Roman", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductQty.ForeColor = Color.FromArgb(16, 107, 67);
            txtProductQty.Location = new Point(192, 32);
            txtProductQty.Margin = new Padding(0);
            txtProductQty.Name = "txtProductQty";
            txtProductQty.PlaceholderText = "1000";
            txtProductQty.Size = new Size(35, 14);
            txtProductQty.TabIndex = 20;
            txtProductQty.TextAlign = HorizontalAlignment.Center;
            txtProductQty.TextChanged += txtProductQty_TextChanged;
            txtProductQty.MouseLeave += txtProductQty_MouseLeave;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(16, 107, 67);
            btnAdd.Image = Properties.Resources.icons8_plus_math_10__1_1;
            btnAdd.Location = new Point(231, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(17, 15);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "-";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = Color.White;
            btnSubstract.FlatAppearance.BorderSize = 0;
            btnSubstract.FlatStyle = FlatStyle.Flat;
            btnSubstract.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubstract.ForeColor = Color.FromArgb(16, 107, 67);
            btnSubstract.Image = Properties.Resources.icons8_subtract_101;
            btnSubstract.Location = new Point(171, 31);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(15, 15);
            btnSubstract.TabIndex = 16;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = false;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 1F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.White;
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.SeaGreen;
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 20;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.Black;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(164, 28);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(89, 21);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 18;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 1;
            cyberButton1.Timer_RGB = 1;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.White;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.ForeColor = Color.White;
            btndelete.Image = Properties.Resources.icons8_delete_162;
            btndelete.Location = new Point(336, 1);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(19, 21);
            btndelete.TabIndex = 8;
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // lbSubTotalPriceKh
            // 
            lbSubTotalPriceKh.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubTotalPriceKh.ForeColor = Color.FromArgb(16, 107, 67);
            lbSubTotalPriceKh.Location = new Point(293, 21);
            lbSubTotalPriceKh.Name = "lbSubTotalPriceKh";
            lbSubTotalPriceKh.Size = new Size(60, 12);
            lbSubTotalPriceKh.TabIndex = 6;
            lbSubTotalPriceKh.Text = "៛ 1,800";
            lbSubTotalPriceKh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbGrandTotalPrice
            // 
            lbGrandTotalPrice.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGrandTotalPrice.ForeColor = Color.FromArgb(16, 107, 67);
            lbGrandTotalPrice.Location = new Point(299, 37);
            lbGrandTotalPrice.Name = "lbGrandTotalPrice";
            lbGrandTotalPrice.Size = new Size(61, 12);
            lbGrandTotalPrice.TabIndex = 7;
            lbGrandTotalPrice.Text = "$ 14.25000";
            lbGrandTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lablePrice
            // 
            lablePrice.AutoSize = true;
            lablePrice.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablePrice.ForeColor = Color.FromArgb(16, 107, 67);
            lablePrice.Location = new Point(115, 37);
            lablePrice.Name = "lablePrice";
            lablePrice.Size = new Size(43, 13);
            lablePrice.TabIndex = 7;
            lablePrice.Text = "$ 4.250";
            // 
            // labelbarcode
            // 
            labelbarcode.AutoSize = true;
            labelbarcode.Font = new Font("Times New Roman", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbarcode.ForeColor = Color.FromArgb(70, 84, 69);
            labelbarcode.Location = new Point(110, 54);
            labelbarcode.Name = "labelbarcode";
            labelbarcode.Size = new Size(70, 12);
            labelbarcode.TabIndex = 4;
            labelbarcode.Text = "8850127004397";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 84, 69);
            label3.Location = new Point(70, 54);
            label3.Name = "label3";
            label3.Size = new Size(39, 12);
            label3.TabIndex = 5;
            label3.Text = "Barcode:";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Font = new Font("Times New Roman", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSize.ForeColor = Color.Black;
            lbSize.Location = new Point(70, 28);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(21, 10);
            lbSize.TabIndex = 3;
            lbSize.Text = "200g";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(47, 155, 70);
            label1.Location = new Point(70, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 12);
            label1.TabIndex = 2;
            label1.Text = "Sale Price:";
            // 
            // lbDiscountAmount
            // 
            lbDiscountAmount.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiscountAmount.ForeColor = Color.Red;
            lbDiscountAmount.Location = new Point(299, 53);
            lbDiscountAmount.Name = "lbDiscountAmount";
            lbDiscountAmount.Size = new Size(55, 12);
            lbDiscountAmount.TabIndex = 2;
            lbDiscountAmount.Text = "$ 0.00000";
            lbDiscountAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 7.25F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(247, 53);
            label4.Name = "label4";
            label4.Size = new Size(46, 12);
            label4.TabIndex = 2;
            label4.Text = "Discount:";
            // 
            // lableName
            // 
            lableName.AutoSize = true;
            lableName.FlatStyle = FlatStyle.Flat;
            lableName.Font = new Font("Times New Roman", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableName.Location = new Point(70, 1);
            lableName.MaximumSize = new Size(250, 30);
            lableName.Name = "lableName";
            lableName.Size = new Size(249, 24);
            lableName.TabIndex = 2;
            lableName.Text = "SHOKUBUTSU WHITENING SAKURA 3 VITAMINS BODY FOAM 500ML";
            lableName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picProduct
            // 
            picProduct.BackColor = Color.Transparent;
            picProduct.Location = new Point(1, 2);
            picProduct.Margin = new Padding(0);
            picProduct.Name = "picProduct";
            picProduct.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            picProduct.Size = new Size(67, 67);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            picProduct.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // UC_ProuductForCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCard);
            Name = "UC_ProuductForCart";
            Size = new Size(362, 72);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
        }

        /*private OrderDetailResponse currentlySelectedProduct = null;

        private void UC_ProuductForCard_Click(object sender, EventArgs e)
        {
            if (currentlySelectedProduct==null || currentlySelectedProduct != _product)
            {
                // Update the currently selected product
                currentlySelectedProduct = _product;

                // Set the border style of the clicked product
                this.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                // Reset the border style of the previously selected product
                this.BorderStyle = BorderStyle.None;
            }
        }*/


        #endregion

        public ReaLTaiizor.Controls.MaterialCard panelCard;
        //private PictureBox picProduct;
        public ReaLTaiizor.Controls.HopePictureBox picProduct;
        private Label lableName;
        private Label lbSize;
        private Label label1;
        private Label labelbarcode;
        private Label label3;
        private Label lablePrice;
        private Label label4;
        private Label lbDiscountAmount;
        private Label lbGrandTotalPrice;
        private Button btndelete;
        private Label lbSubTotalPriceKh;
        private TextBox txtProductQty;
        private Button btnAdd;
        private Button btnSubstract;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private Label lbSubTotalPrice;
    }
}
