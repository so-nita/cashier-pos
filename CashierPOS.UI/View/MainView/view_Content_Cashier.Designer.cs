using CashierPOS.UI.Components;
using CashierPOS.UI.UserControls;

namespace CashierPOS.UI.View_Content_Cashier
{
    partial class view_Content_Cashier
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
        /*private void InitializeComponentData()
        {
            *//*btnCashier.Enabled = false;
            btnCancle.Enabled = false;
            btnPayment.Enabled = false; 
            btnHoldOrder.Enabled = false;
            btnReprint.Enabled = false;
            btnDiscount.Enabled = false;
            btnReturn.Enabled = false;
            btnCustomer.Enabled = false;*//*
        }*/
        private void InitializeComponentData()
        {
            //ActiveControl = textBox_ScanInput;
            //--panelCategory.Location = new Point(10, 3);
            //--panelCategory.Size = new Size(885, 43);

            //--panelSearch.Location = new Point(1040, 8);
            //--panelSearch.Size = new Size(159, 31);

            //--textBox_ScanInput.Location = new Point(6, 9);
            //--textBox_ScanInput.Size = new Size(148, 14);
        }
        /// </summary>
        private void InitializeComponent()
        {
            panelContentCashier = new Panel();
            panelHeader = new Panel();
            panelSearch = new ReaLTaiizor.Controls.MaterialCard();
            textBox_ScanInput = new TextBox();
            panelCategory = new FlowLayoutPanel();
            panelHeaderHover = new Panel();
            panel1 = new Panel();
            pictureBoxContent = new PictureBox();
            panelMainSubTotal = new Panel();
            panelContainUC_Footer = new Panel();
            panelSubTotal = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbPriceTotalKH = new Label();
            lbPriceDeliveryFeesKH = new Label();
            lbPriceDiscountKH = new Label();
            lbPriceSubtotalKH = new Label();
            label8 = new Label();
            label7 = new Label();
            lbPriceDiscount = new Label();
            lbPriceSubtotal = new Label();
            lbNameTotal = new Label();
            lbNameDeliveryFees = new Label();
            lbNameDiscount = new Label();
            lbNameSubtotal = new Label();
            mtcSubtotal = new ReaLTaiizor.Controls.MaterialCard();
            panelContentCashier.SuspendLayout();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContent).BeginInit();
            panelMainSubTotal.SuspendLayout();
            panelSubTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panelContentCashier
            // 
            panelContentCashier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContentCashier.BackColor = Color.FromArgb(215, 234, 213);
            panelContentCashier.Controls.Add(panelHeader);
            panelContentCashier.Controls.Add(panel1);
            panelContentCashier.Controls.Add(panelMainSubTotal);
            panelContentCashier.Location = new Point(0, 0);
            panelContentCashier.Name = "panelContentCashier";
            panelContentCashier.Size = new Size(1270, 855);
            panelContentCashier.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(16, 107, 67);
            panelHeader.Controls.Add(panelSearch);
            panelHeader.Controls.Add(panelCategory);
            panelHeader.Controls.Add(panelHeaderHover);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1270, 50);
            panelHeader.TabIndex = 16;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelSearch.BackColor = Color.FromArgb(255, 255, 255);
            panelSearch.Controls.Add(textBox_ScanInput);
            panelSearch.Depth = 0;
            panelSearch.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelSearch.Location = new Point(1040, 8);
            panelSearch.Margin = new Padding(14);
            panelSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(14);
            panelSearch.Size = new Size(159, 31);
            panelSearch.TabIndex = 3;
            // 
            // textBox_ScanInput
            // 
            textBox_ScanInput.BorderStyle = BorderStyle.None;
            textBox_ScanInput.Font = new Font("Times New Roman", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ScanInput.ForeColor = Color.Black;
            textBox_ScanInput.Location = new Point(6, 7);
            textBox_ScanInput.Name = "textBox_ScanInput";
            textBox_ScanInput.Size = new Size(148, 14);
            textBox_ScanInput.PlaceholderText = "  Scan or input barcode";
            textBox_ScanInput.TabIndex = 4;
            // 
            // panelCategory
            // 
            panelCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCategory.Cursor = Cursors.Hand;
            panelCategory.Location = new Point(10, 3);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(885, 43);
            panelCategory.TabIndex = 4;
            panelCategory.WrapContents = false;
            // 
            // panelHeaderHover
            // 
            panelHeaderHover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHeaderHover.Cursor = Cursors.Hand;
            panelHeaderHover.Location = new Point(4, 5);
            panelHeaderHover.Name = "panelHeaderHover";
            panelHeaderHover.Padding = new Padding(0, 2, 0, 0);
            panelHeaderHover.Size = new Size(65535, 0);
            panelHeaderHover.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBoxContent);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 727);
            panel1.TabIndex = 15;
            // 
            // pictureBoxContent
            // 
            pictureBoxContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxContent.BackgroundImage = Properties.Resources.King_Mart_Logo2;
            pictureBoxContent.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxContent.Location = new Point(28, 72);
            pictureBoxContent.Name = "pictureBoxContent";
            pictureBoxContent.Size = new Size(799, 605);
            pictureBoxContent.TabIndex = 5;
            pictureBoxContent.TabStop = false;
            // 
            // panelMainSubTotal
            // 
            panelMainSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelMainSubTotal.Controls.Add(panelContainUC_Footer);
            panelMainSubTotal.Controls.Add(panelSubTotal);
            panelMainSubTotal.Controls.Add(mtcSubtotal);
            panelMainSubTotal.Location = new Point(855, 50);
            panelMainSubTotal.Name = "panelMainSubTotal";
            panelMainSubTotal.Size = new Size(415, 733);
            panelMainSubTotal.TabIndex = 14;
            // 
            // panelContainUC_Footer
            // 
            panelContainUC_Footer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainUC_Footer.BackColor = Color.Transparent;
            panelContainUC_Footer.Location = new Point(4, 590);
            panelContainUC_Footer.Name = "panelContainUC_Footer";
            panelContainUC_Footer.Size = new Size(402, 173);
            panelContainUC_Footer.TabIndex = 3;
            // 
            // panelSubTotal
            // 
            panelSubTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSubTotal.BackColor = Color.FromArgb(176, 215, 181);
            panelSubTotal.Controls.Add(label4);
            panelSubTotal.Controls.Add(label3);
            panelSubTotal.Controls.Add(label2);
            panelSubTotal.Controls.Add(label1);
            panelSubTotal.Controls.Add(lbPriceTotalKH);
            panelSubTotal.Controls.Add(lbPriceDeliveryFeesKH);
            panelSubTotal.Controls.Add(lbPriceDiscountKH);
            panelSubTotal.Controls.Add(lbPriceSubtotalKH);
            panelSubTotal.Controls.Add(label8);
            panelSubTotal.Controls.Add(label7);
            panelSubTotal.Controls.Add(lbPriceDiscount);
            panelSubTotal.Controls.Add(lbPriceSubtotal);
            panelSubTotal.Controls.Add(lbNameTotal);
            panelSubTotal.Controls.Add(lbNameDeliveryFees);
            panelSubTotal.Controls.Add(lbNameDiscount);
            panelSubTotal.Controls.Add(lbNameSubtotal);
            panelSubTotal.Location = new Point(8, 423);
            panelSubTotal.Name = "panelSubTotal";
            panelSubTotal.Size = new Size(379, 155);
            panelSubTotal.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(219, 123);
            label4.Name = "label4";
            label4.Size = new Size(11, 17);
            label4.TabIndex = 28;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 85);
            label3.Name = "label3";
            label3.Size = new Size(11, 17);
            label3.TabIndex = 27;
            label3.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 51);
            label2.Name = "label2";
            label2.Size = new Size(11, 17);
            label2.TabIndex = 26;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 17);
            label1.Name = "label1";
            label1.Size = new Size(11, 17);
            label1.TabIndex = 25;
            label1.Text = ":";
            // 
            // lbPriceTotalKH
            // 
            lbPriceTotalKH.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbPriceTotalKH.Location = new Point(243, 122);
            lbPriceTotalKH.Name = "lbPriceTotalKH";
            lbPriceTotalKH.Size = new Size(86, 20);
            lbPriceTotalKH.TabIndex = 23;
            lbPriceTotalKH.Text = "0​ ៛​";
            lbPriceTotalKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPriceDeliveryFeesKH
            // 
            lbPriceDeliveryFeesKH.Font = new Font("Times New Roman", 11.25F);
            lbPriceDeliveryFeesKH.Location = new Point(243, 87);
            lbPriceDeliveryFeesKH.Name = "lbPriceDeliveryFeesKH";
            lbPriceDeliveryFeesKH.Size = new Size(86, 17);
            lbPriceDeliveryFeesKH.TabIndex = 22;
            lbPriceDeliveryFeesKH.Text = "0​ ៛";
            lbPriceDeliveryFeesKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPriceDiscountKH
            // 
            lbPriceDiscountKH.Font = new Font("Times New Roman", 11.25F);
            lbPriceDiscountKH.Location = new Point(243, 53);
            lbPriceDiscountKH.Name = "lbPriceDiscountKH";
            lbPriceDiscountKH.Size = new Size(86, 17);
            lbPriceDiscountKH.TabIndex = 21;
            lbPriceDiscountKH.Text = "0​ ៛";
            lbPriceDiscountKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPriceSubtotalKH
            // 
            lbPriceSubtotalKH.Font = new Font("Times New Roman", 11.25F);
            lbPriceSubtotalKH.Location = new Point(243, 19);
            lbPriceSubtotalKH.Name = "lbPriceSubtotalKH";
            lbPriceSubtotalKH.Size = new Size(86, 17);
            lbPriceSubtotalKH.TabIndex = 20;
            lbPriceSubtotalKH.Text = "0​ ៛";
            lbPriceSubtotalKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(120, 121);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 19;
            label8.Text = "$ 0.00";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 11.25F);
            label7.Location = new Point(120, 86);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 18;
            label7.Text = "$ 0.00";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbPriceDiscount
            // 
            lbPriceDiscount.Font = new Font("Times New Roman", 11.25F);
            lbPriceDiscount.Location = new Point(120, 52);
            lbPriceDiscount.Name = "lbPriceDiscount";
            lbPriceDiscount.Size = new Size(90, 17);
            lbPriceDiscount.TabIndex = 17;
            lbPriceDiscount.Text = "$ 0.00";
            lbPriceDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbPriceSubtotal
            // 
            lbPriceSubtotal.Font = new Font("Times New Roman", 11.25F);
            lbPriceSubtotal.Location = new Point(120, 18);
            lbPriceSubtotal.Name = "lbPriceSubtotal";
            lbPriceSubtotal.Size = new Size(90, 17);
            lbPriceSubtotal.TabIndex = 16;
            lbPriceSubtotal.Text = "$ 0.00";
            lbPriceSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNameTotal
            // 
            lbNameTotal.AutoSize = true;
            lbNameTotal.FlatStyle = FlatStyle.Flat;
            lbNameTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbNameTotal.Location = new Point(20, 121);
            lbNameTotal.Name = "lbNameTotal";
            lbNameTotal.Size = new Size(52, 19);
            lbNameTotal.TabIndex = 15;
            lbNameTotal.Text = "Total :";
            // 
            // lbNameDeliveryFees
            // 
            lbNameDeliveryFees.AutoSize = true;
            lbNameDeliveryFees.Font = new Font("Times New Roman", 11.25F);
            lbNameDeliveryFees.Location = new Point(20, 86);
            lbNameDeliveryFees.Name = "lbNameDeliveryFees";
            lbNameDeliveryFees.Size = new Size(97, 17);
            lbNameDeliveryFees.TabIndex = 14;
            lbNameDeliveryFees.Text = "Delivery Fees :";
            // 
            // lbNameDiscount
            // 
            lbNameDiscount.AutoSize = true;
            lbNameDiscount.Font = new Font("Times New Roman", 11.25F);
            lbNameDiscount.Location = new Point(20, 52);
            lbNameDiscount.Name = "lbNameDiscount";
            lbNameDiscount.Size = new Size(67, 17);
            lbNameDiscount.TabIndex = 13;
            lbNameDiscount.Text = "Discount :";
            // 
            // lbNameSubtotal
            // 
            lbNameSubtotal.AutoSize = true;
            lbNameSubtotal.Font = new Font("Times New Roman", 11.25F);
            lbNameSubtotal.Location = new Point(20, 18);
            lbNameSubtotal.Name = "lbNameSubtotal";
            lbNameSubtotal.Size = new Size(62, 17);
            lbNameSubtotal.TabIndex = 12;
            lbNameSubtotal.Text = "Subtotal :";
            // 
            // mtcSubtotal
            // 
            mtcSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtcSubtotal.BackColor = Color.FromArgb(255, 255, 255);
            mtcSubtotal.Depth = 0;
            mtcSubtotal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mtcSubtotal.Location = new Point(8, 423);
            mtcSubtotal.Margin = new Padding(14);
            mtcSubtotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtcSubtotal.Name = "mtcSubtotal";
            mtcSubtotal.Padding = new Padding(14);
            mtcSubtotal.Size = new Size(379, 155);
            mtcSubtotal.TabIndex = 1;
            // 
            // view_Content_Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 855);
            Controls.Add(panelContentCashier);
            FormBorderStyle = FormBorderStyle.None;
            Name = "view_Content_Cashier";
            Text = "view_Content_Cashier";
            Load += View_Content_Cashier_Load;
            panelContentCashier.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxContent).EndInit();
            panelMainSubTotal.ResumeLayout(false);
            panelSubTotal.ResumeLayout(false);
            panelSubTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContentCashier;
        private Panel panelSubTotal;
        private ReaLTaiizor.Controls.MaterialCard mtcSubtotal;
        private Label lbPriceTotalKH;
        private Label lbPriceDeliveryFeesKH;
        private Label lbPriceDiscountKH;
        private Label lbPriceSubtotalKH;
        private Label label8;
        private Label label7;
        private Label lbPriceDiscount;
        private Label lbPriceSubtotal;
        private Label lbNameTotal;
        private Label lbNameDeliveryFees;
        private Label lbNameDiscount;
        private Label lbNameSubtotal;
        private Panel panelMainSubTotal;
        private Panel panelContainUC_Footer;
        private Panel panel1;
        private PictureBox pictureBoxContent;
        private Panel panelHeader;
        private ReaLTaiizor.Controls.MaterialCard panelSearch;
        private TextBox textBox_ScanInput;
        private FlowLayoutPanel panelCategory;
        private Panel panelHeaderHover;
        private UC_AllButton UC_AllButton;
        private CustomTouchScroll _scrollCategory;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private bool UserLoggedOut { get; set; }=false;
    }
}