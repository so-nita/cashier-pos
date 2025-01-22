using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Product;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Model;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_FooterTotal : UserControl
    {
        public OrderTotalForFooterResponse Data = null!;
        public IParentView _parentView;

        public UC_FooterTotal(IParentView parentView)
        {
            _parentView = parentView;
            InitializeComponent();
        }

        private decimal? _cachedExchangeRate;

        private decimal _exchangeRate
        {
            get
            {
                if (!_cachedExchangeRate.HasValue || _parentView.ReturnOrder?.Details?.Count==0)
                {
                    _cachedExchangeRate = AppStoreContext.CurrentUser?.ExchangeRate ?? 0;
                }
                else
                {
                    _cachedExchangeRate = AppStoreContext.CurrentUser.SaleExchangeRate ?? 0;
                }
                return _cachedExchangeRate.Value;
            }
        }

        public OrderTotalForFooterResponse CalculateTotal(List<ProductResponse> data)
        {
            var products = data.Where(e => e.Status != OrderItemStatus.Cancel.ToString());
            var subTotal = products.Sum(e => e.Price * e.Qty);
            /*var discountAmount = (data. != 0 && product.DiscountAmount != null) ? product.DiscountAmount
            : (product.DiscountPercent * product.Price) / 100;*/
            decimal? discount = 0;
            foreach (var product in products)
            {
                var discountAmount = (product.DiscountAmount != 0 && product.DiscountAmount != null) ? product.DiscountAmount
                               : (product.DiscountPercent * product.Price) / 100;
                discount += (discountAmount ?? 0) * product.Qty;
            }

            /*var discount = (discountAmount ?? 0) * product.Qty;*/
            var total = subTotal - discount ?? 0;
            var totalKh = total * _exchangeRate;
            Data = new OrderTotalForFooterResponse()
            {
                SubTotal = subTotal,
                SubTotal_Kh = subTotal * _exchangeRate,
                Deliery_Fee = 0,
                Deliery_Fee_Kh = 0,
                Total = total,
                Discount = discount,
                Discount_Kh = discount * _exchangeRate,
                OrderDate = DateTime.Now,
                TotalKhr = CustomStyle.RoundUpCurrencyKh(totalKh)
            };
            InitProductTotal();
            return Data;
        }

        private void InitProductTotal()
        {
            lableSubTotal.Text = "$ " + Data.SubTotal.ToString(/*"N2"*/);
            LabelSubTotal_Kh.Text = Data.SubTotal_Kh.ToString("N0") ;
            LabelDeliery_Fee_Kh.Text = (Data.Deliery_Fee_Kh ?? 0).ToString("N0") ;
            lableDiscount.Text = "$ " + Data.Discount?.ToString("N2");
            labelDiscount_Kh.Text = Data.Discount_Kh?.ToString("N0") ;
            lableTotal.Text = "$ " + Data.Total.ToString("N2");
            LabelTotalKhr.Text = Data.TotalKhr.ToString("N0") ;

            int locationLableKh = LabelSubTotal_Kh.Width + 264;
            // update location of "រ"
            UpdateLableKhLocation(locationLableKh);
        }
 
        private void UpdateLableKhLocation(int locationLableKh)
        {
            label5.Location = new Point(locationLableKh, 9);
            label6.Location = new Point(locationLableKh, 42);
            label7.Location = new Point(locationLableKh, 75);
            label8.Location = new Point(locationLableKh+4, 106);
        }
    }
}
