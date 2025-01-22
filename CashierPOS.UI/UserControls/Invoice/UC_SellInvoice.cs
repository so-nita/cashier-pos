using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.UserControls;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.UI.Testing
{
    public partial class UC_SellInvoice : UserControl
    {
        private SellInvoiceResponse _receipts = null!;
        public event EventHandler RequestClose = null!;

        public UC_SellInvoice(SellInvoiceResponse receipts)
        { 
            InitializeComponent();
            _receipts = receipts;
            if (_receipts != null)
            {
                GetInvoiceData();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnPrint.Visible = false;
            btnPreview.Visible = false;
            Printer.PrintReceipt(this);
            // Trigger the event when btnPrint is clicked
            //-- RequestClose?.Invoke(this, EventArgs.Empty);
            showBtn();
        }
        private void showBtn()
        {
            btnBack.Visible = true;
            btnPrint.Visible = true;
            btnPreview.Visible = true;
        }

        public event EventHandler IsPreview = null!;
        private void btn_preview_Click(object sender, EventArgs e)
        {
            //PopUp_Background.Form.TopMost = false;
            IsPreview?.Invoke(this, EventArgs.Empty);
            ExportPDF.ExportPdfFile(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RequestClose?.Invoke(this, EventArgs.Empty);
        }

        private void GetInvoiceData()
        {
            if (_receipts != null)
            {
                foreach (var item in _receipts.OrderTransaction!)
                {
                    var userControl = new UC_ProductInInvoice();
                    userControl.Product = item;
                    panelListProduct.Controls.Add(userControl);
                    panelListProduct.Controls.SetChildIndex(userControl, 0);
                }
                InitData(_receipts);
                panelSummaryFooter.Location = new Point(12, panelListProduct.Bottom);
            }
            this.Height = panelSummaryFooter.Bottom + 110;
        }
        private void InitData(SellInvoiceResponse invoice)
        {
            var totalKh = CustomStyle.RoundUpCurrencyKh(invoice.Total_Kh);
            //var changeKh = CustomStyle.RoundDownCurrencyKh(invoice.ChangeKh??0);

            lbCompnayNameKh.Text = invoice.Company_NameKh;
            lbAddress.Text = invoice.Company_Address;
            lbCompanyName.Text = invoice.Company_Name;
            //lbCustomerType.Text = invoice.Customer_Type;
            lbDate.Text = invoice.Print_Date.ToString("dd-MM-yy hh:mm tt");
            lbInvoiceNo.Text = invoice.InvoiceNo;
            lbContact.Text = invoice.Company_Contact;
            lbCashierName.Text = invoice.Cashier_Id;
            // footer
            lbTotalUSD.Text = "$ " + invoice.Total.ToString("N2");
            lbTotalKh.Text = totalKh.ToString("N0") + " ៛";
            //lbExchangeRate.Text = invoice.ExchangeRate.ToString("N0") + " ៛";
            lbDeliveryFee.Text = "$ " + (invoice.DeliveryFee == 0 ? "-" : (invoice.DeliveryFee ?? 0.00m).ToString("N2"));
            lbDiscount.Text = "$ " + ((invoice.Discount == 0) ? "-" : invoice.Discount?.ToString("N2"));
            lbReceived.Text = "$ " + ((invoice.Received == 0) ? "-" : invoice.Received?.ToString("N2"));
            lbReceivedKh.Text = (invoice.ReceivedKh == 0) ? "-" : invoice.ReceivedKh?.ToString("N0") + " ៛";
            lbChange.Text = "$ " + ((invoice.Change == 0) ? "-" : invoice.Change?.ToString("N2"));
            lbChangeKh.Text = (invoice.ChangeKh == 0) ? "-" : invoice.ChangeKh?.ToString("N0") + " ៛";
            // Generate Barcode 
            lbInvoiceBarcode.Text = invoice.InvoiceNo;
            GenerateInvoiceBarCode(invoice.InvoiceNo);
        }

        private void GenerateInvoiceBarCode(string invoiceNo)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxInoviceBarCode.Image = barcode.Draw(invoiceNo, 50);
        }
    }
}