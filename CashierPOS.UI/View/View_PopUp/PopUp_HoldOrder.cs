using CashierPOS.Model.Models.Order;
using CashierPOS.UI.Components;
using CashierPOS.UI.Interface;
using CashierPOS.UI.UserControls;
using CashierPOS.UI.View_PopUp;

namespace CashierPOS.UI.View.View_PopUp
{
    public partial class PopUp_HoldOrder : Form
    {
        private readonly IParentView _parentView;
        private List<HoldOrderResponse> _order;

        private readonly CustomTouchScroll _touchScroll;
        public PopUp_HoldOrder(IParentView parentView, List<HoldOrderResponse> order)
        {
            _parentView = parentView;
            _order = order;
            InitializeComponent();
            _touchScroll = new CustomTouchScroll(panelListHoldOrder, Constant.ScrollDirection.Vertical);
        }

        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            InitializeData();
            panelListHoldOrder_Paint();
        }

        //Function get Dynamic Label and Textbox
        private void InitializeData()
        {
            for (var i = 0; i < _order.Count; i++)
            {
                var order = new OrderResponseDto
                {
                    OrderNo = i + 1,
                    OrderDate = _order[i].OrderDate,
                    ExchangeRate = _order[i].ExchangeRate,
                    //Is_Delete = _order[i].Is_Delete,
                    OrderId = _order[i].OrderId,
                    OrderStatus = _order[i].OrderStatus,
                    ShiftId = _order[i].ShiftId,
                    Total = _order[i].Total,
                    TotalKh = _order[i].TotalKh,
                    OrderDetails = _order[i].OrderDetails,
                };
                var userControl = new UC_HoldCart(_parentView, order);
                userControl.IsHoldOrder += ReHoldOrder_Clicked;
                userControl.IsRecartClicked += RecartItem_Clicked;
                userControl.CloseFormRequest += UserControl_CloseFormRequest;
                panelListHoldOrder.Controls.Add(userControl);
                _touchScroll.AssignScrollEvent(userControl);
            }
        }

        private void ReHoldOrder_Clicked(object? sender, bool e)
        {
            ReHoldOrderClicked.Invoke(sender, e);
        }

        public event EventHandler<bool> IsRecartClicked;
        public event EventHandler<bool> ReHoldOrderClicked;
        private void RecartItem_Clicked(object? sender, bool e)
        {
            IsRecartClicked?.Invoke(this, true);
        }

        private void UserControl_CloseFormRequest(object? sender, OrderResponse order)
        {
            this.Close();
            PopUp_Background.ClosePopUp();

            //var form = new PopUp_Cancel(_parentView, order);
            var form = new PopUp_DeleteHoldOrder(_parentView, order);
            form.lbNameCancel.Text = "Delete Order";
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.Show();
        }

        private void panelListHoldOrder_Paint()
        {
            panelListHoldOrder.AutoScroll = false;
            panelListHoldOrder.HorizontalScroll.Maximum = 0;
            panelListHoldOrder.VerticalScroll.Maximum = 0;
            panelListHoldOrder.AutoScroll = true;
        }

        private void btnCloseDelete_Click(object sender, EventArgs e)
        {
           /* if (_parentView.HoldOrder?.OrderDetails?.Count>0)
            {
                _parentView.NumberHoldOrder--;
            }
            _parentView.ReloadNotificationHoldOrder();*/
            PopUp_Background.ClosePopUp();
        }
    }
    public class OrderResponseDto : HoldOrderResponse
    {
        public int OrderNo { get; set; }
    }
}