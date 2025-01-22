using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.Product;
using CashierPOS.UI.Interface;
using CashierPOS.UI.View.View_PopUp;
using CashierPOS.UI.View_PopUp;

namespace CashierPOS.UI.UserControls
{
    public partial class UC_HoldCart : UserControl
    {
        private readonly IParentView _parentView;
        private readonly OrderResponseDto _order;

        public UC_HoldCart(IParentView parentView, OrderResponseDto order)
        {
            InitializeComponent();
            _parentView = parentView;
            _order = order;
            InitializeData();
        }

        private void InitializeData()
        {
            lbOrderNo.Text = "#" + _order.OrderNo.ToString("D4");
            lbOrderItem.Text = _order.OrderDetails.Where(e=>e.Status==OrderItemStatus.Close)!.Count().ToString();
            lbOrderDate.Text = _order.OrderDate.ToString("dd-MMM-yyyy hh:mm:ss tt");
            lbTotal.Text = "$ " + _order.Total.ToString("N2");
        }

        public event EventHandler<OrderResponse> CloseFormRequest;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CloseFormRequest?.Invoke(this, GetOrderResponse);
        }

        public event EventHandler<bool> IsRecartClicked;
        public event EventHandler<bool> IsHoldOrder;
        private void btnReCart_Click(object sender, EventArgs e)
        {
            // If has data show on cart so move it to hold order and than we can recart 
            if(_parentView.HoldOrder?.OrderDetails?.Count>0)
            {
                IsHoldOrder.Invoke(sender, true); 
            }
            _parentView.HoldOrder = _order;
            var productInOrder = _parentView.HoldOrder.OrderDetails?.Select(e => new ProductResponse()
            {
                Id = e.Product_Id,
                Code = e.Product_Code,
                Name = e.Product_Name,
                Image = e.Product_Image,
                Price = e.Price,
                Qty = e.Qty,
                Size = e.Size,
                Status = e.Status.ToString(),
                ReasonCode = e.ReasonCode,
                DiscountPercent = e.Discount_Percent,
                DiscountAmount = e.Discount_Amount,
            }).ToList();

            IsRecartClicked?.Invoke(sender, true);
            _parentView.Carts = productInOrder!;
            PopUp_Background.ClosePopUp();
            _parentView.ViewPOS_LoadingData();
        }

        private OrderResponse GetOrderResponse
        {
            get
            {
                return new OrderResponse()
                {
                    OrderId = _order.OrderId,
                    OrderStatus = _order.OrderStatus,
                };
            }
        }
    }
}
