using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.RequestModel.Order;
using CashierPOS.Model.Models.Response;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.View_PopUp;

namespace CashierPOS.UI.View.View_PopUp
{
    public partial class PopUp_DeleteHoldOrder : Form
    {
        private OrderResponse _order;
        private IParentView _parentView;
        public PopUp_DeleteHoldOrder(IParentView parentView, OrderResponse order)
        {
            _parentView = parentView;
            _order = order;
            InitializeComponent();
            comboBoxReason_SelectedIndexChanged();
        }
        //Function cancel for Cancel Form
        private void btnCloseCancel_Click(object sender, EventArgs e)
        {
            RollBackOrder();
            //PopUp_Background.ClosePopUp();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            RollBackOrder();
        }

        private async void RollBackOrder()
        {
            if (_order.OrderStatus == OrderStatus.Hold)
            {
                this.Close();
                PopUp_Background.ClosePopUp();
            }
            else
            {
                var dataRequest = new OrderDeleteReq()
                {
                    Id = _order.OrderId,
                };
                var service = new OrderService();
                var data = await service.DeleteOrderAsync(dataRequest);
                if (data)
                {
                    PopUp_Background.Form = this;
                    PopUp_Background.ClosePopUp();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<ReasonTypeResponse> selectReasonDelete = null!;
        //Function for select Reason Cancel
        private async void comboBoxReason_SelectedIndexChanged()
        {
            /*var service = new ReasonTypeService();
            selectReasonCancel = await service.GetReasonType();
            foreach (var item in selectReasonCancel)
            {
                comboBoxReason.Items.Add(item.Name);
                comboBoxReason.SelectedItem = item.Id;
            }
            comboBoxReason.Text = "Select The Reason";*/
            var service = new ReasonTypeService();
            selectReasonDelete = await service.GetReasonType();

            comboBoxReason.DisplayMember = "Name";
            comboBoxReason.ValueMember = "Id";

            comboBoxReason.Items.Add(new ReasonTypeResponse() { Id = "0", Name = "Select The Reason" });

            foreach (var item in selectReasonDelete)
            {
                comboBoxReason.Items.Add(item);
            }
            comboBoxReason.SelectedIndex = 0;
        }

        private async void GetValueCancle()
        {
            string ReasonCancle = "";
            if (comboBoxReason.SelectedItem != null)
            {
                //var SelectedItem = selectReasonDelete.FirstOrDefault(item => item.Name == comboBoxReason.SelectedItem.ToString())!;
                var selectItem = comboBoxReason.SelectedItem as ReasonTypeResponse;
                if (selectItem != null)
                {
                    ReasonCancle = selectItem.Id;
                }
            }
            if (_order != null)
            {
                var dataCancel = new OrderCancelReq()
                {
                    OrderId = _order.OrderId,
                    ReasonCode = ReasonCancle,
                };

                var service = new OrderService();
                var data = await service.CancelOrderAsync(dataCancel);
                if (data)
                {
                    _parentView.UpdateNumberOfHoldOrder();
                    //_parentView.ReloadNotificationHoldOrder();
                    _parentView.ViewPOS_LoadingData();
                    PopUp_Background.Form = this;
                    PopUp_Background.ClosePopUp();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cancle Failed.");
                }
            }
        }

        //Function for Save Cancel Form
        private void btnSave_Click(object sender, EventArgs e)
        {
           /* if (comboBoxReason.Text == "Select The Reason")
            {
                txtboxMainReason.ColorBackground_Pen = Color.Red;
                //--MessageBox.Show("Please Select The Reason.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxReason.Text == comboBoxReason.Text)
            {
                _parentView.NumberHoldOrder--;
                //--Test_parentView.Carts.Clear();
                txtboxMainReason.ColorBackground_Pen = Color.White;
                GetValueCancle();
            }*/
            if (!CheckIsSelectReason()) return;

            _parentView.NumberHoldOrder--;
            //--Test_parentView.Carts.Clear();
            txtboxMainReason.ColorBackground_Pen = Color.White;
            GetValueCancle();
        }

        private bool CheckIsSelectReason()
        {
            foreach (Control control in panelCancel.Controls)
            {
                if (control == comboBoxReason)
                {
                    var selectItem = comboBoxReason.SelectedItem as ReasonTypeResponse;
                    if (selectItem == null || selectItem.Id == "0")
                    {
                        txtboxMainReason.ColorBackground_Pen = Color.Red;
                    }
                    else
                    {
                        txtboxMainReason.ColorBackground_Pen = Color.FromArgb(47, 155, 70);
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }

        private void comboBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReason.SelectedItem != null)
            {
                // Check if the selected item is of type GiftCouponResponse
                if (comboBoxReason.SelectedItem is ReasonTypeResponse selectItem)
                {
                    // Check if the selected item has Id "0"
                    if (selectItem.Id == "0")
                    {
                        comboBoxReason.Items.RemoveAt(0);
                    }
                }
            }
        }
    }

    public class ReasonTypeService : BaseService
    {
        private string EndPoint = "reasonType";
        private string GetUrl => BaseUrl + EndPoint;

        public async Task<List<ReasonTypeResponse>> GetReasonType()
        {
            var data = await GetAsync<Response<List<ReasonTypeResponse>>>(GetUrl);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return null!;
            }
            return data.Result!;
        }

        public async Task<List<ReasonReturnTypeResponse>> GetReasonReturnType()
        {
            EndPoint = "reasonReturnType";
            var data = await GetAsync<Response<List<ReasonReturnTypeResponse>>>(GetUrl);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return null!;
            }
            return data.Result!;
        }
    }
}