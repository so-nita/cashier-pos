using CashierPOS.Model.Models.ChangeShift;
using CashierPOS.UI.Components;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.View_PopUp;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_ReciepSummary : UserControl
    {
        private CloseShiftSummaryRqsponse _receipt = new();
        //private CashPayment _payment;
        public UC_ReciepSummary(CloseShiftSummaryRqsponse inovice)
        {
            InitializeComponent();
            //--Initialize();
            if (inovice != null)
            {
                _receipt = inovice;
                GetChangeShiftData();
            }
        }

        private void GetChangeShiftData()
        {
            if (_receipt != null)
            {
                InitializeData();
                foreach (var item in _receipt.PaymemtSummary!)
                {
                    var userControl = new UC_ReceiptPaymentSummary();
                    userControl.Payment = item;
                    panelListpaymentSummary.Controls.Add(userControl);
                }
                //DiscountSummary(_receipt.DiscountSummary);
                foreach (var item in _receipt.DiscountSummary?.DiscountPercentage!)
                {
                    var userControl = new UC_ReceiptDiscountSummary("%");
                    userControl.Payment = item;
                    panelListDiscountPer.Controls.Add(userControl);
                }
                foreach (var item in _receipt.DiscountSummary.DiscountAmounts!)
                {
                    var userControl = new UC_ReceiptDiscountSummary("$");
                    userControl.Payment = item;
                    panelListDiscountAmount.Controls.Add(userControl);
                }
                this.Height = panelContainButtons.Bottom + 80;
            }
        }

        private void InitializeData()
        {
            //for shift summary and information company
            lbCompanyNameKh.Text = _receipt.CompanyNameKh;
            lbShop.Text = _receipt.CompanyName;
            lbPosID.Text = _receipt.PosId;
            lbOpenDate.Text = _receipt.OpenDate.ToString("dd-MM-yyyy hh:mm tt");
            lbOpenCash.Text = _receipt.UserName.ToString();
            lbCloseDate.Text = _receipt.CloseDate.ToString("dd-MM-yyyy hh:mm tt");
            lbStartInvoiceNo.Text = _receipt.OpenInvoiceNo;
            lbTo.Text = _receipt.CloseInvoiceNo;

            //Open Till
            lbOpenTill.Text = "$ " + _receipt.OpenTill.ToString("#,0.00");
            lbKHR.Text = _receipt.OpenBalanceKh.ToString("#,##0") + " ៛";
            lbUSD.Text = "$ " + _receipt.OpenBalance.ToString("#,0.00");
            lbClosedAmount.Text = "$ " + _receipt.CloseBalance.ToString("#,0.00");
            lbCountedDiff.Text = "$ " + _receipt.CountedDifferentBalance.ToString("#,0.00").Replace("-","");
            lbTransactionSale.Text = "$ " + _receipt.TotalSalesTransaction.ToString("#,0.00");

            //for sale summary
            lbNumTotalSale.Text = _receipt.QtySubTotalSale.ToString();
            lbAmountsTotalSale.Text = "$ " + _receipt.TotalSale.ToString("#,0.00");
            lbNumTotalRefund.Text = _receipt.QtyReturnTransaction.ToString();
            lbAmountTotalRefund.Text = "$ " + _receipt.TotalReturnTransaction.ToString("#,0.00");
            lbNumTotalVoids.Text = _receipt.QtyVoid.ToString();
            lbAmountTotalVoids.Text = "$ " + _receipt.TotalVoid.ToString("N2");
            lbNumDiscounts.Text = _receipt.QtyDiscountTransaction.ToString();
            lbAmountDiscounts.Text = "$ " + _receipt.TotalDiscountTransaction.ToString("N2");
            lableSubTotal.Text = "$ " + _receipt.SubTotal.ToString("#,0.00");
            lbValVat.Text = "$ " + _receipt.TotalVAT.ToString("#,0.00");
            lbValPublicLighting.Text = "$ " + _receipt.TotalPLT.ToString("#,0.00");
            lbTotal.Text = "$ " + _receipt.TotalPaymentSummary.ToString("#,0.00");
            lbValNetSale.Text = "$ " + _receipt.NetSale.ToString("#,0.00");

            lbCashRiels.Text = _receipt.CashPaymentSummary!.CashPaymentReil.ToString("#,##0") + " ៛";
            lbCashUSD.Text = "$ " + _receipt.CashPaymentSummary.CashPaymentDollar.ToString("#,0.00");
            lbQtyCashRiels.Text = _receipt.CashPaymentSummary.QtyCashInReil.ToString();
            lbQtyCashUSD.Text = _receipt.CashPaymentSummary.QtyCashInDollar.ToString();
            lbCashierCount.Text = "$ " + _receipt.CloseBalance.ToString("#,0.00");

            lbCashierTotalAmount.Text = "$ " + _receipt.CashierTotal?.ToString("#,0.00");
            lbTotalTillWithDrawel.Text = _receipt.TotalTillWithdrawal?.ToString("N0");
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnPrint.Visible = false;
            PopUp_Background.ClosePopUp();
            RequestCloseView?.Invoke(this, EventArgs.Empty);
            Printer.PrintReceipt(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RequestCloseView?.Invoke(this, EventArgs.Empty);
        }
        
        private void lbNameTo_Click(object sender, EventArgs e)
        {

        }
 
        public event EventHandler RequestCloseView;
    }
}