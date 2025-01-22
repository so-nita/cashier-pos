using CashierPOS.UI.Components;
using CashierPOS.UI.Interface;
using System.Windows.Forms;
using TestReceipt;

namespace CashierPOS.UI.View.ViewStock
{
    partial class PopUp_ProductStock
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
            label1 = new Label();
            textBoxSearch = new TextBox();
            pictureBox3 = new PictureBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox2 = new PictureBox();
            panelNameProduct = new Panel();
            lbNameStock = new Label();
            lbNameItem = new Label();
            lbImage_Item = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            panelListproduct = new FlowLayoutPanel();
            btnClose = new Button();
            panelHeaderDelete = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelNameProduct.SuspendLayout();
            materialCard1.SuspendLayout();
            panelHeaderDelete.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 10);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 1;
            label1.Text = "View Product Stock";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Times New Roman", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.ForeColor = SystemColors.ControlText;
            textBoxSearch.Location = new Point(178, 60);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search by name or barcode";
            textBoxSearch.Size = new Size(200, 16);
            textBoxSearch.TabIndex = 87;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.icons8_search_301;
            pictureBox3.Location = new Point(154, 59);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 88;
            pictureBox3.TabStop = false;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.White;
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.Black;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(138, 48);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(254, 40);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 86;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 1;
            cyberButton1.Timer_RGB = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.icons8_search_301;
            pictureBox2.Location = new Point(154, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // panelNameProduct
            // 
            panelNameProduct.BackColor = Color.White;
            panelNameProduct.Controls.Add(lbNameStock);
            panelNameProduct.Controls.Add(lbNameItem);
            panelNameProduct.Controls.Add(lbImage_Item);
            panelNameProduct.Location = new Point(1, 2);
            panelNameProduct.Margin = new Padding(0, 3, 3, 3);
            panelNameProduct.Name = "panelNameProduct";
            panelNameProduct.Padding = new Padding(2, 0, 0, 0);
            panelNameProduct.Size = new Size(495, 40);
            panelNameProduct.TabIndex = 89;
            // 
            // lbNameStock
            // 
            lbNameStock.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbNameStock.Location = new Point(414, 11);
            lbNameStock.Name = "lbNameStock";
            lbNameStock.Size = new Size(52, 19);
            lbNameStock.TabIndex = 33;
            lbNameStock.Text = "Stock";
            lbNameStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNameItem
            // 
            lbNameItem.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbNameItem.Location = new Point(77, 11);
            lbNameItem.Name = "lbNameItem";
            lbNameItem.Size = new Size(335, 19);
            lbNameItem.TabIndex = 32;
            lbNameItem.Text = "Name";
            lbNameItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbImage_Item
            // 
            lbImage_Item.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbImage_Item.Location = new Point(6, 11);
            lbImage_Item.Name = "lbImage_Item";
            lbImage_Item.Size = new Size(61, 19);
            lbImage_Item.TabIndex = 31;
            lbImage_Item.Text = "Image";
            lbImage_Item.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(panelNameProduct);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(20, 96);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(498, 43);
            materialCard1.TabIndex = 91;
            // 
            // panelListproduct
            // 
            panelListproduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListproduct.AutoScroll = true;
            panelListproduct.Cursor = Cursors.Hand;
            panelListproduct.Location = new Point(11, 144);
            panelListproduct.Margin = new Padding(0);
            panelListproduct.Name = "panelListproduct";
            panelListproduct.Padding = new Padding(6, 10, 0, 0);
            panelListproduct.Size = new Size(508, 618);
            panelListproduct.TabIndex = 92;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.can_t1;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(504, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelHeaderDelete
            // 
            panelHeaderDelete.BackColor = Color.FromArgb(47, 155, 70);
            panelHeaderDelete.Controls.Add(label1);
            panelHeaderDelete.Controls.Add(btnClose);
            panelHeaderDelete.Dock = DockStyle.Top;
            panelHeaderDelete.Location = new Point(0, 0);
            panelHeaderDelete.Name = "panelHeaderDelete";
            panelHeaderDelete.Size = new Size(530, 48);
            panelHeaderDelete.TabIndex = 93;
            // 
            // PopUp_ProductStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(530, 772);
            Controls.Add(panelHeaderDelete);
            Controls.Add(panelListproduct);
            Controls.Add(materialCard1);
            Controls.Add(textBoxSearch);
            Controls.Add(pictureBox3);
            Controls.Add(cyberButton1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUp_ProductStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewPorduct";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelNameProduct.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            panelHeaderDelete.ResumeLayout(false);
            panelHeaderDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSearch;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private PictureBox pictureBox2;
        private Panel panelNameProduct;
        private Label lbNameStock;
        private Label lbNameItem;
        private Label lbImage_Item;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private FlowLayoutPanel panelListproduct;
        private Button btnClose;
        private Panel panelHeaderDelete;
    }
}