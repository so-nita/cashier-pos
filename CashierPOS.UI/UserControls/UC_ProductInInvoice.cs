using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_ProductInInvoice : UserControl
    {
        private OrderDetailResponse _product = null!;
        public UC_ProductInInvoice()
        {
            InitializeComponent();
        }
        public OrderDetailResponse Product
        {
            get { return _product; }
            set
            {
                _product = value;
                InitData();
                
            }
        }
        private void InitData()
        {
            if (Product != null)
            {
                lbItemCode.Text = Product.Product_Code;
                lbItemName.Text = Product.Product_Name;
                lbQty.Text = Product.Qty.ToString();
                lbPrice.Text = "$ " + Product.Price.ToString();
                lbNetPrice.Text = "$ " + Product.Grand_Amount.ToString("N2");
            }
        }
    }
}
