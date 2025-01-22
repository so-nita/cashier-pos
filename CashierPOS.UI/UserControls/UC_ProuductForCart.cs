using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Product;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.View;
using CashierPOS.UI.View.View_PopUp.AddProductQty;
using CashierPOS.UI.View_PopUp;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_ProuductForCart : UserControl
    {
        private readonly OrderDetailResponse _product;
        private readonly View_POS _rest;
        public bool IsReturnOrder { get; set; } = false;
        public UC_ProuductForCart(OrderDetailResponse product = null!, View_POS rest = null!)
        {
            _product = product;
            _rest = rest;
            InitializeComponent();
            InitData();
            InitializeComponentData();
        }
        public OrderDetailResponse GetProduct => _product;

        private decimal? _exchangeRate;

        private decimal ExchangeRate
        {
            get
            {
                if (_rest.ReturnOrder?.Details?.Count == 0)
                {
                    if (!_exchangeRate.HasValue)
                    {
                        _exchangeRate = AppStoreContext.CurrentUser?.ExchangeRate ?? 0;
                    }
                }
                else
                {
                    _exchangeRate = AppStoreContext.CurrentUser.SaleExchangeRate ?? 0;
                }
                return _exchangeRate.Value;
            }
        }
         
        private async void InitData()
        {
            if (_product != null)
            {
                lbDiscountAmount.Text = "$ " + (_product.Discount_Amount??0 * _product.Qty).ToString("#,##0.00");
                labelbarcode.Text = _product.Product_Code;
                lablePrice.Text = "$ " + _product.Price.ToString();
                lableName.Text = _product.Product_Name.ToString();
                txtProductQty.Text = _product.Qty.ToString() ?? "1";
                lbSize.Text = _product.Size;
                if (_product.Discount_Amount > 0)
                {
                    lbSubTotalPrice.Visible = true;
                    lbSubTotalPrice.Text = "$ " + (_product.Sub_Amount).ToString();
                }
                lbSubTotalPriceKh.Text = ((_product.Price * ExchangeRate).ToString("N0") ?? "0") + " ៛";
                lbGrandTotalPrice.Text = "$ " + _product.Grand_Amount.ToString("#,##0.00");
                picProduct.Image = await CustomStyle.GetImageFromUrl(_product.Product_Image!);

                IsReturnOrder = _rest.ReturnOrder.Details.Count == 0 ? false : true;
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (IsReturnOrder) return;

            SubstractQuantity();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsReturnOrder) return;

            var product = _rest.Products.First(e => e.Id == _product.Product_Id);
            if (product.Qty > _product.Qty)
            {
                AddQuantity(1);
            }
            else
            {
                MessageBox.Show("Stock item is limit", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddQuantity(int qty)
        {
            var currentQty = Convert.ToInt32(txtProductQty.Text);
            if (qty == 1 && _product.Qty == currentQty)
            {
                _product.Qty += qty;
            }
            else
            {
                _product.Qty = qty;
            }
            _product.Sub_Amount = _product.Price * _product.Qty;
            UpdateQuantity();
            _rest.UC_FooterTotal.CalculateTotal(_rest.Carts);
        }

        private void SubstractQuantity()
        {
            //--- if (_product.Qty > 0)     // change: 25-02-24
            if (_product.Qty > 1)
            {
                _product.Qty -= 1;
                _product.Sub_Amount = (_product.Price * _product.Qty) - _product.Discount_Amount ?? 0;
                UpdateQuantity();
            }
            if (_product.Qty == 0)
            {
                _product.Qty = 1;
                var form = new PopUp_Delete(_rest);
                PopUp_Background.Form = form;

                if (DeleteProduct != null)
                {
                    form.IsCloseForm += DeleteProduct!;
                }
                form.ShowInTaskbar = false;
                PopUp_Background.ShowPopUp();
                var canPay = _rest.Carts.Where(e => e.Status != OrderItemStatus.Cancel.ToString()).Count() > 0;
                _rest.EnablePayment(canPay);
            }
            _rest.UC_FooterTotal.CalculateTotal(_rest.Carts);
        }

        private void DeleteProduct(object sender, bool isClosed)
        {
            if (isClosed)
            {
                UpdateQuantity();
            }
            else
            {
                var product = _rest.Carts.First(e => e.Id == _product.Product_Id);
                product.Qty = 1;
                product.Status = OrderItemStatus.Cancel.ToString();
                this.Hide();
            }
        }
        public void UpdateQuantity()
        {
            var subAmount = _product.Price * _product.Qty;
            //var discount = _product.Discount_Amount ?? 0;
            decimal discount = 0;
            if (_product.Discount_Percent > 0)
            {
                discount = (_product.Price * _product.Discount_Percent ?? 0) / 100;
            }
            else
            {
                discount = _product.Discount_Amount ?? 0;
            }
            decimal discountAmount = discount * _product.Qty;
            _product.Sub_Amount = subAmount;
            _product.Grand_Amount = subAmount - (discountAmount);

            lbDiscountAmount.Text = "$ " + (discountAmount == 0 ? 0.00m : discountAmount).ToString();
            /*if(_product.Discount_Amount > 0)
            {
                lbSubTotalPrice.Visible = true;
                lbSubTotalPrice.Text = "$ " + _product.Sub_Amount.ToString();
            }*/
            lbSubTotalPrice.Text = "$ " + _product.Sub_Amount.ToString("N2");

            lbSubTotalPriceKh.Text = $"{(_product.Grand_Amount * ExchangeRate).ToString("N0") ?? "0"} ៛";
            lbGrandTotalPrice.Text = "$ " + _product.Grand_Amount.ToString("N2");
            txtProductQty.Text = _product.Qty.ToString();

            _rest.Carts.First(e => e.Id == _product.Product_Id).Qty = _product.Qty;
        }

        public event EventHandler<ProductResponse> DeleteButtonClicked;

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Test date : 01-03-2024
            if (IsReturnOrder)
            {
                var retrunOrder = _rest.ReturnOrder.Details?.FirstOrDefault(e => e.Product_Id == _product.Product_Id);
                if (retrunOrder != null)
                {
                    _rest.ReturnOrder.Details.Remove(retrunOrder!);
                    if (_rest.ReturnOrder.Details.Count == 0)
                    {
                        IsReturnOrder = false;
                        _rest.Carts.Clear();
                    }
                    _rest.ViewPOS_LoadingData();
                }
                return;
            }
            //if (IsReturnOrder) return;
            //end test
            if (sender is System.Windows.Forms.Button btn)
            {
                var product = new ProductResponse()
                {
                    Name = _product.Product_Name,
                    Status = OrderItemStatus.Cancel.ToString(),
                    Code = _product.Product_Code,
                    Id = _product.Product_Id,
                    Price = _product.Price,
                    Qty = _product.Qty,
                    Image = _product.Product_Image,
                };
                // Store the event handler in a delegate
                EventHandler<ProductResponse> handler = DeleteButtonClicked;
                // Unsubscribe the event handler
                DeleteButtonClicked -= handler;
                // Invoke the event
                handler?.Invoke(this, product);

                var formCancel = new PopUp_Delete(_rest);
                formCancel.OrderDetail = product;

                PopUp_Background.Form = formCancel;
                PopUp_Background.ShowPopUp();
            }
        }

        private void lableQty_Click(object sender, EventArgs e)
        {
            var form = new PopUp_AddQtyProduct();
            form.ShowInTaskbar = false;

            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }


        private void txtProductQty_TextChanged(object sender, EventArgs e)
        {
            var data = txtProductQty.Text == "" ? null : txtProductQty.Text.Trim();
            if (data == null)
            {
                return;
            }
            var qty = Convert.ToInt32(data);
            if (qty == 0)
            {
                txtProductQty.Text = "1";
                txtProductQty.SelectionStart = txtProductQty.TextLength;
                return;
            }

            if (_product.Qty != qty)
            {
                var product = _rest.Products.FirstOrDefault(e => e.Id == _product.Product_Id);
                if (product.Qty > qty)
                {
                    AddQuantity(qty);
                }
                else
                {
                    MessageBox.Show("Stock item is limited", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Reset the text to the previous quantity
                    txtProductQty.Text = _product.Qty.ToString();
                    txtProductQty.SelectionStart = txtProductQty.TextLength;
                }
            }

        }
        private void txtProductQty_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductQty.Text) || Convert.ToInt32(txtProductQty.Text) == 0)
            {
                txtProductQty.Text = _product.Qty.ToString();
                txtProductQty.SelectionStart = txtProductQty.TextLength;
            }
        }

    }
}