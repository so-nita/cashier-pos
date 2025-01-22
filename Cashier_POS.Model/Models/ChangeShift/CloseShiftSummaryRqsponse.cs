using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CashierPOS.Model.Models.ChangeShift
{
    public class CloseShiftSummaryRqsponse
    {
        public string UserName { get; set; } = "";
        public string PosId { get; set; } = "";
        public string OpenInvoiceNo { get; set; } = "";
        public string CloseInvoiceNo { get; set; } = "";
        public string CompanyName { get; set; } = "";
        public string CompanyNameKh { get; set; } = "";
        public string CompanyAddress { get; set; } = "";
        public string CompanyContact { get; set; } = "";
        public DateTime PrintDate { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public decimal OpenTill { get; set; }
        public decimal OpenBalance { get; set; }
        public decimal OpenBalanceKh { get; set; }
        public decimal CloseBalance { get; set; }
        public decimal CountedDifferentBalance { get; set; }
        public int QtyVoid { get; set; }
        public decimal TotalVoid { get; set; }
        public int QtySalesTransaction {  get; set; }
        public decimal TotalSalesTransaction {  get; set; }
        public int QtyReturnTransaction {  get; set; }
        public decimal TotalReturnTransaction {  get; set; }
        public int QtyDiscountTransaction {  get; set; }
        public decimal TotalDiscountTransaction {  get; set; }
        public int QtySubTotalSale { get; set; }
        public decimal SubTotal { get; set; }   
        public decimal NetSale { get; set; }   
        public decimal TotalVAT {  get; set; }  
        public decimal TotalPLT {  get; set; }  
        public decimal TotalNonVAT {  get; set; }
        public decimal TotalPaymentSummary {  get; set; }
        public decimal? Change {  get; set; }
        public decimal? CashierTotal {  get; set; }
        public decimal? TotalTillWithdrawal {  get; set; }
        public ICollection<SellPaymentMethod>? PaymemtSummary { get; set; }
        public DiscountTypeSummary? DiscountSummary { get; set; }
        public CashPayment? CashPaymentSummary { get; set; }
        public decimal TotalSale { get; set; }
    }
}
