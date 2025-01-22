namespace CashierPOS.UI.UserControls.Invoice
{
    partial class UC_SellInvoiceReturn
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
        private void Initialize()
        {
            //btnBack.Location = new Point(70, 2);
            //btnPrint.Location = new Point(177, 2);
            btnPrint.Click += btnPrint_Click;
            btnBack.Click += btnBack_Click;
        }
        /// </summary>
        private void InitializeComponent()
        {
            panelMainReceipt = new FlowLayoutPanel();
            panel1 = new Panel();
            lbCompnayNameKh = new Label();
            lbAddress = new Label();
            lbLine1 = new Label();
            pictureBoxRedant = new PictureBox();
            lbNameVatKH = new Label();
            lbNameInvoiceEN = new Label();
            lbTaxTypeNo = new Label();
            AddKH = new Label();
            lbNameInvoiceKH = new Label();
            label2 = new Panel();
            label3 = new Label();
            panel2 = new FlowLayoutPanel();
            lbNameBranch = new Label();
            lbCompanyName = new Label();
            lb_CreditNoted = new Label();
            lb_CreditNotedNo = new Label();
            lbName_KH = new Label();
            lbCashierName = new Label();
            lbNameDate = new Label();
            lbDate = new Label();
            lbContact = new Label();
            lbNamePhoneNumber = new Label();
            label_RefNo = new Label();
            lbReferenceInvoiceNo = new Label();
            lbPoint1 = new Label();
            panelNameProduct = new Panel();
            lbNameNetPrice = new Label();
            lbNamePrice = new Label();
            lbNameQty = new Label();
            lbNameItemDes = new Label();
            lbNameNetPriceKH = new Label();
            lbNamePriceKH = new Label();
            lbNameQtyKH = new Label();
            lbNameItemKH = new Label();
            panelListProduct = new FlowLayoutPanel();
            lbLine2 = new Label();
            panelSummaryFooter = new FlowLayoutPanel();
            panelDelivery = new Panel();
            lbTotalKh = new Label();
            lbTotalUSD = new Label();
            lbDiscount = new Label();
            lbNameTotalRielEN = new Label();
            lbNameTotalRielKH = new Label();
            lbNameTotalUSDEN = new Label();
            lbNameTotalUSDKH = new Label();
            lbNameDeliveryEN = new Label();
            lbNameDeliveryKH = new Label();
            lbNameThankYou = new Label();
            panel3 = new Panel();
            btnBack = new ReaLTaiizor.Controls.HopeButton();
            btnPreview = new ReaLTaiizor.Controls.HopeButton();
            btnPrint = new ReaLTaiizor.Controls.HopeButton();
            panelMainReceipt.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedant).BeginInit();
            panel2.SuspendLayout();
            panelNameProduct.SuspendLayout();
            panelSummaryFooter.SuspendLayout();
            panelDelivery.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainReceipt
            // 
            panelMainReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainReceipt.AutoScroll = true;
            panelMainReceipt.AutoSize = true;
            panelMainReceipt.BackColor = Color.White;
            panelMainReceipt.Controls.Add(panel1);
            panelMainReceipt.Controls.Add(label3);
            panelMainReceipt.Controls.Add(panel2);
            panelMainReceipt.Controls.Add(lbPoint1);
            panelMainReceipt.Controls.Add(panelNameProduct);
            panelMainReceipt.Controls.Add(panelListProduct);
            panelMainReceipt.Controls.Add(lbLine2);
            panelMainReceipt.Controls.Add(panelSummaryFooter);
            panelMainReceipt.Controls.Add(panel3);
            panelMainReceipt.Location = new Point(0, 0);
            panelMainReceipt.Margin = new Padding(0, 3, 0, 0);
            panelMainReceipt.MaximumSize = new Size(4200, 0);
            panelMainReceipt.MinimumSize = new Size(285, 470);
            panelMainReceipt.Name = "panelMainReceipt";
            panelMainReceipt.Size = new Size(291, 515);
            panelMainReceipt.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCompnayNameKh);
            panel1.Controls.Add(lbAddress);
            panel1.Controls.Add(lbLine1);
            panel1.Controls.Add(pictureBoxRedant);
            panel1.Controls.Add(lbNameVatKH);
            panel1.Controls.Add(lbNameInvoiceEN);
            panel1.Controls.Add(lbTaxTypeNo);
            panel1.Controls.Add(AddKH);
            panel1.Controls.Add(lbNameInvoiceKH);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.MaximumSize = new Size(330, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 162);
            panel1.TabIndex = 1;
            // 
            // lbCompnayNameKh
            // 
            lbCompnayNameKh.Font = new Font("Khmer OS Content", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCompnayNameKh.Location = new Point(0, 48);
            lbCompnayNameKh.Name = "lbCompnayNameKh";
            lbCompnayNameKh.Size = new Size(282, 23);
            lbCompnayNameKh.TabIndex = 73;
            lbCompnayNameKh.Text = "រេដ​ អាន អិចប្រេស ឯ.ក";
            lbCompnayNameKh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAddress
            // 
            lbAddress.Font = new Font("Khmer OS Content", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(70, 90);
            lbAddress.Margin = new Padding(0);
            lbAddress.MaximumSize = new Size(230, 50);
            lbAddress.MinimumSize = new Size(178, 30);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(212, 38);
            lbAddress.TabIndex = 72;
            lbAddress.Text = "ផ្ទះលេខ ១៣៩១៣ ផ្លូវ៥៩៨ ភូមិខ១, ច្រាំងចំរេះទី២ ខណ្ឌឬស្សីកែវ​ រាជធានីភ្នំពេញ";
            // 
            // lbLine1
            // 
            lbLine1.AutoSize = true;
            lbLine1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbLine1.Location = new Point(0, 124);
            lbLine1.Margin = new Padding(0);
            lbLine1.Name = "lbLine1";
            lbLine1.Size = new Size(283, 15);
            lbLine1.TabIndex = 71;
            lbLine1.Text = "  ______________________________________________________";
            lbLine1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxRedant
            // 
            pictureBoxRedant.Image = Properties.Resources.logo_red_ant;
            pictureBoxRedant.Location = new Point(89, -2);
            pictureBoxRedant.Name = "pictureBoxRedant";
            pictureBoxRedant.Size = new Size(106, 55);
            pictureBoxRedant.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRedant.TabIndex = 63;
            pictureBoxRedant.TabStop = false;
            // 
            // lbNameVatKH
            // 
            lbNameVatKH.Font = new Font("Khmer OS Content", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameVatKH.Location = new Point(5, 72);
            lbNameVatKH.Margin = new Padding(0);
            lbNameVatKH.Name = "lbNameVatKH";
            lbNameVatKH.Size = new Size(188, 19);
            lbNameVatKH.TabIndex = 3;
            lbNameVatKH.Text = "លេខអត្តសញ្ញាណសារពើពន្ធ(VATTIN)៖​ ";
            // 
            // lbNameInvoiceEN
            // 
            lbNameInvoiceEN.AutoSize = true;
            lbNameInvoiceEN.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameInvoiceEN.Location = new Point(147, 142);
            lbNameInvoiceEN.Name = "lbNameInvoiceEN";
            lbNameInvoiceEN.Size = new Size(81, 13);
            lbNameInvoiceEN.TabIndex = 8;
            lbNameInvoiceEN.Text = "CREDIT NOTE";
            // 
            // lbTaxTypeNo
            // 
            lbTaxTypeNo.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTaxTypeNo.Location = new Point(190, 74);
            lbTaxTypeNo.Margin = new Padding(0);
            lbTaxTypeNo.Name = "lbTaxTypeNo";
            lbTaxTypeNo.Size = new Size(93, 15);
            lbTaxTypeNo.TabIndex = 4;
            lbTaxTypeNo.Text = "K008-902200332";
            lbTaxTypeNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddKH
            // 
            AddKH.AutoSize = true;
            AddKH.Font = new Font("Khmer OS Content", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddKH.Location = new Point(6, 90);
            AddKH.Margin = new Padding(0);
            AddKH.Name = "AddKH";
            AddKH.Size = new Size(67, 19);
            AddKH.TabIndex = 4;
            AddKH.Text = "អាសយដ្ឋាន៖";
            AddKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNameInvoiceKH
            // 
            lbNameInvoiceKH.AutoSize = true;
            lbNameInvoiceKH.Font = new Font("Khmer OS Content", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameInvoiceKH.Location = new Point(64, 140);
            lbNameInvoiceKH.Name = "lbNameInvoiceKH";
            lbNameInvoiceKH.Size = new Size(84, 19);
            lbNameInvoiceKH.TabIndex = 7;
            lbNameInvoiceKH.Text = "ប័ណ្ណឥណទាន/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 711);
            label2.Name = "label2";
            label2.Size = new Size(0, 0);
            label2.TabIndex = 70;
            label2.Text = "____________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Content", 12F);
            label3.Location = new Point(3, 168);
            label3.Name = "label3";
            label3.Size = new Size(0, 29);
            label3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbNameBranch);
            panel2.Controls.Add(lbCompanyName);
            panel2.Controls.Add(lb_CreditNoted);
            panel2.Controls.Add(lb_CreditNotedNo);
            panel2.Controls.Add(lbName_KH);
            panel2.Controls.Add(lbCashierName);
            panel2.Controls.Add(lbNameDate);
            panel2.Controls.Add(lbDate);
            panel2.Controls.Add(lbContact);
            panel2.Controls.Add(lbNamePhoneNumber);
            panel2.Controls.Add(label_RefNo);
            panel2.Controls.Add(lbReferenceInvoiceNo);
            panel2.Location = new Point(6, 171);
            panel2.Margin = new Padding(0, 3, 0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 75);
            panel2.TabIndex = 69;
            // 
            // lbNameBranch
            // 
            lbNameBranch.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameBranch.Location = new Point(4, 0);
            lbNameBranch.Margin = new Padding(4, 0, 3, 0);
            lbNameBranch.Name = "lbNameBranch";
            lbNameBranch.Size = new Size(62, 16);
            lbNameBranch.TabIndex = 26;
            lbNameBranch.Text = "សាខាហាង   ៖";
            // 
            // lbCompanyName
            // 
            lbCompanyName.Font = new Font("Khmer OS Content", 7F);
            lbCompanyName.Location = new Point(69, 0);
            lbCompanyName.Margin = new Padding(0, 0, 3, 0);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(178, 19);
            lbCompanyName.TabIndex = 27;
            lbCompanyName.Text = "101-រេដ អាន អិចប្រស ទួលគោក";
            lbCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_CreditNoted
            // 
            lb_CreditNoted.AutoSize = true;
            lb_CreditNoted.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_CreditNoted.Location = new Point(2, 19);
            lb_CreditNoted.Margin = new Padding(2, 0, 3, 0);
            lb_CreditNoted.Name = "lb_CreditNoted";
            lb_CreditNoted.Size = new Size(63, 16);
            lb_CreditNoted.TabIndex = 30;
            lb_CreditNoted.Text = "ប័ណ្ណឥណទាន៖";
            lb_CreditNoted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_CreditNotedNo
            // 
            lb_CreditNotedNo.AutoSize = true;
            lb_CreditNotedNo.Font = new Font("Times New Roman", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_CreditNotedNo.Location = new Point(68, 20);
            lb_CreditNotedNo.Margin = new Padding(0, 1, 3, 0);
            lb_CreditNotedNo.Name = "lb_CreditNotedNo";
            lb_CreditNotedNo.Size = new Size(101, 12);
            lb_CreditNotedNo.TabIndex = 31;
            lb_CreditNotedNo.Text = "SCN101-01-240523586";
            lb_CreditNotedNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbName_KH
            // 
            lbName_KH.AutoSize = true;
            lbName_KH.Font = new Font("Khmer OS Content", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName_KH.Location = new Point(176, 19);
            lbName_KH.Margin = new Padding(4, 0, 3, 0);
            lbName_KH.Name = "lbName_KH";
            lbName_KH.Size = new Size(54, 16);
            lbName_KH.TabIndex = 32;
            lbName_KH.Text = "អ្នកគិតលុយ៖";
            lbName_KH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCashierName
            // 
            lbCashierName.AutoSize = true;
            lbCashierName.Font = new Font("Times New Roman", 7.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCashierName.Location = new Point(233, 20);
            lbCashierName.Margin = new Padding(0, 1, 3, 0);
            lbCashierName.Name = "lbCashierName";
            lbCashierName.Size = new Size(45, 12);
            lbCashierName.TabIndex = 33;
            lbCashierName.Text = "RAE0004";
            lbCashierName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNameDate
            // 
            lbNameDate.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameDate.Location = new Point(2, 35);
            lbNameDate.Margin = new Padding(2, 0, 3, 0);
            lbNameDate.Name = "lbNameDate";
            lbNameDate.Size = new Size(66, 16);
            lbNameDate.TabIndex = 34;
            lbNameDate.Text = "កាលបរិច្ឆេទ    ៖";
            // 
            // lbDate
            // 
            lbDate.Font = new Font("Times New Roman", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(71, 35);
            lbDate.Margin = new Padding(0, 0, 3, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(64, 16);
            lbDate.TabIndex = 35;
            lbDate.Text = "04-01-24 4:15";
            lbDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbContact
            // 
            lbContact.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContact.Location = new Point(142, 35);
            lbContact.Margin = new Padding(4, 0, 3, 0);
            lbContact.Name = "lbContact";
            lbContact.Size = new Size(57, 19);
            lbContact.TabIndex = 36;
            lbContact.Text = "លេខទូរស័ព្ទ ៖";
            lbContact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNamePhoneNumber
            // 
            lbNamePhoneNumber.Font = new Font("Times New Roman", 7.25F);
            lbNamePhoneNumber.Location = new Point(202, 35);
            lbNamePhoneNumber.Margin = new Padding(0, 0, 3, 0);
            lbNamePhoneNumber.Name = "lbNamePhoneNumber";
            lbNamePhoneNumber.Size = new Size(63, 16);
            lbNamePhoneNumber.TabIndex = 37;
            lbNamePhoneNumber.Text = "023 666 6696";
            lbNamePhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_RefNo
            // 
            label_RefNo.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_RefNo.Location = new Point(2, 54);
            label_RefNo.Margin = new Padding(2, 0, 3, 0);
            label_RefNo.Name = "label_RefNo";
            label_RefNo.Size = new Size(87, 16);
            label_RefNo.TabIndex = 38;
            label_RefNo.Text = "យោងវិក្កយបត្រលេខ ៖";
            // 
            // lbReferenceInvoiceNo
            // 
            lbReferenceInvoiceNo.Font = new Font("Times New Roman", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbReferenceInvoiceNo.Location = new Point(92, 54);
            lbReferenceInvoiceNo.Margin = new Padding(0, 0, 3, 0);
            lbReferenceInvoiceNo.Name = "lbReferenceInvoiceNo";
            lbReferenceInvoiceNo.Size = new Size(115, 16);
            lbReferenceInvoiceNo.TabIndex = 39;
            lbReferenceInvoiceNo.Text = ".................................";
            lbReferenceInvoiceNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPoint1
            // 
            lbPoint1.AutoSize = true;
            lbPoint1.Location = new Point(3, 249);
            lbPoint1.Name = "lbPoint1";
            lbPoint1.Padding = new Padding(2, 0, 0, 0);
            lbPoint1.Size = new Size(285, 15);
            lbPoint1.TabIndex = 73;
            lbPoint1.Text = "............................................................................................";
            // 
            // panelNameProduct
            // 
            panelNameProduct.Controls.Add(lbNameNetPrice);
            panelNameProduct.Controls.Add(lbNamePrice);
            panelNameProduct.Controls.Add(lbNameQty);
            panelNameProduct.Controls.Add(lbNameItemDes);
            panelNameProduct.Controls.Add(lbNameNetPriceKH);
            panelNameProduct.Controls.Add(lbNamePriceKH);
            panelNameProduct.Controls.Add(lbNameQtyKH);
            panelNameProduct.Controls.Add(lbNameItemKH);
            panelNameProduct.Location = new Point(0, 267);
            panelNameProduct.Margin = new Padding(0, 3, 3, 3);
            panelNameProduct.Name = "panelNameProduct";
            panelNameProduct.Padding = new Padding(2, 0, 0, 0);
            panelNameProduct.Size = new Size(286, 37);
            panelNameProduct.TabIndex = 74;
            // 
            // lbNameNetPrice
            // 
            lbNameNetPrice.AutoSize = true;
            lbNameNetPrice.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameNetPrice.Location = new Point(223, 22);
            lbNameNetPrice.Name = "lbNameNetPrice";
            lbNameNetPrice.Size = new Size(51, 14);
            lbNameNetPrice.TabIndex = 34;
            lbNameNetPrice.Text = "Net Price";
            // 
            // lbNamePrice
            // 
            lbNamePrice.AutoSize = true;
            lbNamePrice.Font = new Font("Times New Roman", 9F);
            lbNamePrice.Location = new Point(186, 21);
            lbNamePrice.Name = "lbNamePrice";
            lbNamePrice.Size = new Size(31, 15);
            lbNamePrice.TabIndex = 33;
            lbNamePrice.Text = "Price";
            // 
            // lbNameQty
            // 
            lbNameQty.AutoSize = true;
            lbNameQty.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameQty.Location = new Point(142, 21);
            lbNameQty.Name = "lbNameQty";
            lbNameQty.Size = new Size(34, 14);
            lbNameQty.TabIndex = 32;
            lbNameQty.Text = "   Qty";
            // 
            // lbNameItemDes
            // 
            lbNameItemDes.AutoSize = true;
            lbNameItemDes.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameItemDes.Location = new Point(10, 21);
            lbNameItemDes.Name = "lbNameItemDes";
            lbNameItemDes.Size = new Size(86, 14);
            lbNameItemDes.TabIndex = 31;
            lbNameItemDes.Text = "Item Description";
            // 
            // lbNameNetPriceKH
            // 
            lbNameNetPriceKH.AutoSize = true;
            lbNameNetPriceKH.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameNetPriceKH.Location = new Point(230, 3);
            lbNameNetPriceKH.Name = "lbNameNetPriceKH";
            lbNameNetPriceKH.Size = new Size(42, 16);
            lbNameNetPriceKH.TabIndex = 30;
            lbNameNetPriceKH.Text = "ថ្លៃទំនិញ";
            // 
            // lbNamePriceKH
            // 
            lbNamePriceKH.AutoSize = true;
            lbNamePriceKH.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNamePriceKH.Location = new Point(186, 3);
            lbNamePriceKH.Name = "lbNamePriceKH";
            lbNamePriceKH.Size = new Size(42, 16);
            lbNamePriceKH.TabIndex = 29;
            lbNamePriceKH.Text = "ថ្លៃឯកតា";
            // 
            // lbNameQtyKH
            // 
            lbNameQtyKH.AutoSize = true;
            lbNameQtyKH.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameQtyKH.Location = new Point(139, 3);
            lbNameQtyKH.Name = "lbNameQtyKH";
            lbNameQtyKH.Size = new Size(45, 16);
            lbNameQtyKH.TabIndex = 28;
            lbNameQtyKH.Text = "​ បរិមាណ";
            // 
            // lbNameItemKH
            // 
            lbNameItemKH.AutoSize = true;
            lbNameItemKH.Font = new Font("Khmer OS Content", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameItemKH.Location = new Point(10, 1);
            lbNameItemKH.Name = "lbNameItemKH";
            lbNameItemKH.Size = new Size(56, 16);
            lbNameItemKH.TabIndex = 27;
            lbNameItemKH.Text = "ឈ្មោះទំនិញ";
            // 
            // panelListProduct
            // 
            panelListProduct.AutoSize = true;
            panelListProduct.Location = new Point(5, 310);
            panelListProduct.Margin = new Padding(5, 3, 0, 3);
            panelListProduct.MaximumSize = new Size(310, 0);
            panelListProduct.MinimumSize = new Size(280, 20);
            panelListProduct.Name = "panelListProduct";
            panelListProduct.Padding = new Padding(2, 0, 2, 0);
            panelListProduct.Size = new Size(280, 20);
            panelListProduct.TabIndex = 75;
            // 
            // lbLine2
            // 
            lbLine2.AutoSize = true;
            lbLine2.Location = new Point(3, 333);
            lbLine2.Name = "lbLine2";
            lbLine2.Padding = new Padding(2, 0, 0, 0);
            lbLine2.Size = new Size(282, 15);
            lbLine2.TabIndex = 76;
            lbLine2.Text = " ______________________________________________________\r\n";
            // 
            // panelSummaryFooter
            // 
            panelSummaryFooter.Controls.Add(panelDelivery);
            panelSummaryFooter.Controls.Add(lbNameThankYou);
            panelSummaryFooter.Location = new Point(3, 351);
            panelSummaryFooter.MaximumSize = new Size(400, 0);
            panelSummaryFooter.MinimumSize = new Size(280, 20);
            panelSummaryFooter.Name = "panelSummaryFooter";
            panelSummaryFooter.Size = new Size(282, 86);
            panelSummaryFooter.TabIndex = 77;
            // 
            // panelDelivery
            // 
            panelDelivery.AutoSize = true;
            panelDelivery.Controls.Add(lbTotalKh);
            panelDelivery.Controls.Add(lbTotalUSD);
            panelDelivery.Controls.Add(lbDiscount);
            panelDelivery.Controls.Add(lbNameTotalRielEN);
            panelDelivery.Controls.Add(lbNameTotalRielKH);
            panelDelivery.Controls.Add(lbNameTotalUSDEN);
            panelDelivery.Controls.Add(lbNameTotalUSDKH);
            panelDelivery.Controls.Add(lbNameDeliveryEN);
            panelDelivery.Controls.Add(lbNameDeliveryKH);
            panelDelivery.Dock = DockStyle.Top;
            panelDelivery.Location = new Point(3, 3);
            panelDelivery.Margin = new Padding(3, 3, 0, 3);
            panelDelivery.Name = "panelDelivery";
            panelDelivery.Size = new Size(279, 58);
            panelDelivery.TabIndex = 67;
            // 
            // lbTotalKh
            // 
            lbTotalKh.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalKh.Location = new Point(209, 42);
            lbTotalKh.Name = "lbTotalKh";
            lbTotalKh.Padding = new Padding(0, 0, 4, 0);
            lbTotalKh.Size = new Size(66, 15);
            lbTotalKh.TabIndex = 48;
            lbTotalKh.Text = "29,700 ៛​ ";
            lbTotalKh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTotalUSD
            // 
            lbTotalUSD.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lbTotalUSD.Location = new Point(208, 22);
            lbTotalUSD.Name = "lbTotalUSD";
            lbTotalUSD.Padding = new Padding(0, 0, 4, 0);
            lbTotalUSD.Size = new Size(67, 15);
            lbTotalUSD.TabIndex = 47;
            lbTotalUSD.Text = "7.16 $";
            lbTotalUSD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbDiscount
            // 
            lbDiscount.Font = new Font("Times New Roman", 9.75F);
            lbDiscount.Location = new Point(200, 4);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Padding = new Padding(0, 0, 4, 0);
            lbDiscount.Size = new Size(76, 15);
            lbDiscount.TabIndex = 46;
            lbDiscount.Text = "$ -";
            lbDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNameTotalRielEN
            // 
            lbNameTotalRielEN.AutoSize = true;
            lbNameTotalRielEN.Font = new Font("Times New Roman", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameTotalRielEN.Location = new Point(76, 43);
            lbNameTotalRielEN.Name = "lbNameTotalRielEN";
            lbNameTotalRielEN.Size = new Size(129, 12);
            lbNameTotalRielEN.TabIndex = 41;
            lbNameTotalRielEN.Text = "/ Total (All tax included)-Riel:";
            // 
            // lbNameTotalRielKH
            // 
            lbNameTotalRielKH.AutoSize = true;
            lbNameTotalRielKH.Font = new Font("Khmer OS Content", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameTotalRielKH.Location = new Point(3, 40);
            lbNameTotalRielKH.Name = "lbNameTotalRielKH";
            lbNameTotalRielKH.Size = new Size(76, 18);
            lbNameTotalRielKH.TabIndex = 40;
            lbNameTotalRielKH.Text = "សរុប [ រួមអាករ​ ] ";
            // 
            // lbNameTotalUSDEN
            // 
            lbNameTotalUSDEN.AutoSize = true;
            lbNameTotalUSDEN.Font = new Font("Times New Roman", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameTotalUSDEN.Location = new Point(75, 25);
            lbNameTotalUSDEN.Name = "lbNameTotalUSDEN";
            lbNameTotalUSDEN.Size = new Size(135, 12);
            lbNameTotalUSDEN.TabIndex = 39;
            lbNameTotalUSDEN.Text = "/ Total (All tax included) -USD:";
            // 
            // lbNameTotalUSDKH
            // 
            lbNameTotalUSDKH.AutoSize = true;
            lbNameTotalUSDKH.Font = new Font("Khmer OS Content", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameTotalUSDKH.Location = new Point(3, 22);
            lbNameTotalUSDKH.Name = "lbNameTotalUSDKH";
            lbNameTotalUSDKH.Size = new Size(73, 18);
            lbNameTotalUSDKH.TabIndex = 38;
            lbNameTotalUSDKH.Text = "សរុប [ រួមអាករ​ ]";
            // 
            // lbNameDeliveryEN
            // 
            lbNameDeliveryEN.AutoSize = true;
            lbNameDeliveryEN.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameDeliveryEN.Location = new Point(146, 5);
            lbNameDeliveryEN.Name = "lbNameDeliveryEN";
            lbNameDeliveryEN.Size = new Size(51, 14);
            lbNameDeliveryEN.TabIndex = 37;
            lbNameDeliveryEN.Text = "Discount:";
            // 
            // lbNameDeliveryKH
            // 
            lbNameDeliveryKH.AutoSize = true;
            lbNameDeliveryKH.Font = new Font("Khmer OS Content", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameDeliveryKH.Location = new Point(94, 4);
            lbNameDeliveryKH.Name = "lbNameDeliveryKH";
            lbNameDeliveryKH.Size = new Size(52, 18);
            lbNameDeliveryKH.TabIndex = 36;
            lbNameDeliveryKH.Text = "បញ្ចុះតម្លៃ /";
            // 
            // lbNameThankYou
            // 
            lbNameThankYou.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameThankYou.Location = new Point(3, 64);
            lbNameThankYou.Name = "lbNameThankYou";
            lbNameThankYou.Size = new Size(287, 15);
            lbNameThankYou.TabIndex = 62;
            lbNameThankYou.Text = "Thank You for choosing \"Red Ant Express\" !!";
            lbNameThankYou.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(btnPreview);
            panel3.Controls.Add(btnPrint);
            panel3.Location = new Point(3, 443);
            panel3.MaximumSize = new Size(410, 0);
            panel3.MinimumSize = new Size(280, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 60);
            panel3.TabIndex = 79;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BorderColor = Color.FromArgb(220, 223, 230);
            btnBack.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnBack.DangerColor = Color.FromArgb(245, 108, 108);
            btnBack.DefaultColor = Color.FromArgb(255, 255, 255);
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnBack.InfoColor = Color.FromArgb(144, 147, 153);
            btnBack.Location = new Point(5, 20);
            btnBack.Name = "btnBack";
            btnBack.PrimaryColor = Color.Red;
            btnBack.Size = new Size(80, 35);
            btnBack.SuccessColor = Color.FromArgb(103, 194, 58);
            btnBack.TabIndex = 80;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.White;
            btnBack.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.FromArgb(176, 215, 181);
            btnPreview.BorderColor = Color.FromArgb(220, 223, 230);
            btnPreview.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnPreview.DangerColor = Color.FromArgb(245, 108, 108);
            btnPreview.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPreview.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnPreview.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPreview.InfoColor = Color.FromArgb(144, 147, 153);
            btnPreview.Location = new Point(196, 20);
            btnPreview.Name = "btnPreview";
            btnPreview.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnPreview.Size = new Size(80, 35);
            btnPreview.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPreview.TabIndex = 81;
            btnPreview.Text = "Preview";
            btnPreview.TextColor = Color.White;
            btnPreview.WarningColor = Color.FromArgb(230, 162, 60);
            btnPreview.Click += btnPreview_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(176, 215, 181);
            btnPrint.BorderColor = Color.FromArgb(220, 223, 230);
            btnPrint.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnPrint.DangerColor = Color.FromArgb(245, 108, 108);
            btnPrint.DefaultColor = Color.FromArgb(255, 255, 255);
            btnPrint.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnPrint.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnPrint.InfoColor = Color.FromArgb(144, 147, 153);
            btnPrint.Location = new Point(100, 20);
            btnPrint.Name = "btnPrint";
            btnPrint.PrimaryColor = Color.FromArgb(47, 155, 70);
            btnPrint.Size = new Size(80, 35);
            btnPrint.SuccessColor = Color.FromArgb(103, 194, 58);
            btnPrint.TabIndex = 81;
            btnPrint.Text = "Print";
            btnPrint.TextColor = Color.White;
            btnPrint.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // UC_SellInvoiceReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainReceipt);
            MinimumSize = new Size(290, 485);
            Name = "UC_SellInvoiceReturn";
            Size = new Size(290, 520);
            panelMainReceipt.ResumeLayout(false);
            panelMainReceipt.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedant).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelNameProduct.ResumeLayout(false);
            panelNameProduct.PerformLayout();
            panelSummaryFooter.ResumeLayout(false);
            panelSummaryFooter.PerformLayout();
            panelDelivery.ResumeLayout(false);
            panelDelivery.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private FlowLayoutPanel panelMainReceipt;
        private Label lbNameInvoiceKH;
        private Label AddKH;
        private Label label3;
        private Label lbNameVatKH;
        private Label lbTaxTypeNo;
        private PictureBox pictureBoxRedant;
        private Panel panel1;
        private Label lbNameInvoiceEN;
        private Panel label2;
        private FlowLayoutPanel panel2;
        private Label lbNameBranch;
        private Label lbCompanyName;
        private Label lb_CreditNoted;
        private Label lb_CreditNotedNo;
        private Label lbName_KH;
        private Label lbCashierName;
        private Label lbNameDate;
        private Label lbDate;
        private Label lbContact;
        private Label lbNamePhoneNumber;
        private Label lbPoint1;
        private Panel panelNameProduct;
        private Label lbNameNetPrice;
        private Label lbNamePrice;
        private Label lbNameQty;
        private Label lbNameItemDes;
        private Label lbNameNetPriceKH;
        private Label lbNamePriceKH;
        private Label lbNameQtyKH;
        private Label lbNameItemKH;
        private FlowLayoutPanel panelListProduct;
        private Label lbLine2;
        private FlowLayoutPanel panelSummaryFooter;
        private Panel panelDelivery;
        private Label lbTotalKh;
        private Label lbTotalUSD;
        private Label lbDiscount;
        private Label lbNameTotalRielEN;
        private Label lbNameTotalRielKH;
        private Label lbNameTotalUSDEN;
        private Label lbNameTotalUSDKH;
        private Label lbNameDeliveryEN;
        private Label lbNameDeliveryKH;
        private Label lbNameThankYou;
        private Label lbLine1;
        private Label lbAddress;
        private Label lbCompnayNameKh;
        private Label label_RefNo;
        private Label lbReferenceInvoiceNo;
        private Panel panel3;
        private ReaLTaiizor.Controls.HopeButton btnBack;
        private ReaLTaiizor.Controls.HopeButton btnPrint;
        private ReaLTaiizor.Controls.HopeButton btnPreview;
    }
}
