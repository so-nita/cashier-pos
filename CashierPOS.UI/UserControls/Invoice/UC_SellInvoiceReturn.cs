using CashierPOS.UI.CustomStyles;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.UI.UserControls.Invoice
{
    public partial class UC_SellInvoiceReturn : UserControl
    {
        private SellInvoiceResponse _receipts = null!;
        public event EventHandler RequestClose = null!;
        public event EventHandler IsPreview = null!;

        public UC_SellInvoiceReturn(SellInvoiceResponse receipts)
        {
            InitializeComponent();
            Initialize();
            _receipts = receipts;
            if (_receipts != null)
            {
                GetInvoiceData();
            }
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

            lbReferenceInvoiceNo.Text = invoice.OldInvoiceNo;
            lbCompnayNameKh.Text = invoice.Company_NameKh;
            lbAddress.Text = invoice.Company_Address;
            lbCompanyName.Text = invoice.Company_Name;
            lbCompanyName.Text = invoice.Customer_Type;
            lbDate.Text = invoice.Print_Date.ToString("dd-MM-yy hh:mm tt");
            lb_CreditNotedNo.Text = invoice.InvoiceNo;
            lbCashierName.Text = invoice.Cashier_Id;
            lbNamePhoneNumber.Text = invoice.Company_Contact;
            // footer
            lbTotalUSD.Text = "$ " + invoice.Total.ToString("N2");
            lbTotalKh.Text = totalKh.ToString("N0") + " ៛";
            lbDiscount.Text = "$ " + ((invoice.Discount == 0) ? "-" : invoice.Discount?.ToString("N2"));
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //PopUp_Background.Form.TopMost = false;
            IsPreview?.Invoke(this, EventArgs.Empty);
            ExportPDF.ExportPdfFile(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RequestClose?.Invoke(this, EventArgs.Empty);
        }
    }
}
