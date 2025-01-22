using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Product;
using CashierPOS.Model.Models.ReasonType;
using CashierPOS.UI.Interface;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_Delete : Form
    {
        private IParentView _parentView;
        public ProductResponse OrderDetail { get; set; }
        public PopUp_Delete(IParentView parentView)
        {
            InitializeComponent();
            comboBoxReason_SelectedIndexChanged();
            _parentView = parentView;
        }

        public event EventHandler<bool> IsCloseForm;
        //Function Cancel Delete Form
        private void btnCancle_Click(object sender, EventArgs e)
        {
            IsCloseForm?.Invoke(sender, true);

            PopUp_Background.ClosePopUp();
            this.Close();
        }

        private List<ReasonTypeResponse> selectReasonDelete;
        //Function Select Reason Delete
        private async void comboBoxReason_SelectedIndexChanged()
        {
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

        //Function Save Delete Form
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if (comboBoxReason.Text == "Select the reason")
            {
                txtboxMainReason.ColorBackground_Pen = Color.Red;
            }
            else if (comboBoxReason.Text == comboBoxReason.Text)
            {
                txtboxMainReason.ColorBackground_Pen = Color.White;
                GetvalueDelete();
                PopUp_Background.ClosePopUp();
                this.Close();
                IsCloseForm?.Invoke(sender, false);
            }*/
            if (!CheckIsSelectReason()) return;

            txtboxMainReason.ColorBackground_Pen = Color.White;
            GetvalueDelete();
            PopUp_Background.ClosePopUp();
            this.Close();
            IsCloseForm?.Invoke(sender, false);
        }
        private bool CheckIsSelectReason()
        {
            foreach (Control control in panelDelete.Controls)
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

        private void GetvalueDelete()
        {
            string reasonDelete = "";
            if (comboBoxReason.SelectedItem != null)
            {
                var selectItem = comboBoxReason.SelectedItem as ReasonTypeResponse;
                if (selectItem != null)
                {
                    reasonDelete = selectItem.Id;
                }
            }
            if (OrderDetail != null)
            {
                var product = _parentView.Carts.FirstOrDefault(e => e.Id == OrderDetail.Id);

                if (product != null)
                {
                    product.ReasonCode = reasonDelete;
                    product.Status = OrderItemStatus.Cancel.ToString();
                }
                _parentView.ViewPOS_LoadingData();
                this.Close();
            }
        }
 
        //Function Close Delete Form
        private void btnCloseDelete_Click(object sender, EventArgs e)
        {
            IsCloseForm?.Invoke(sender, true);

            PopUp_Background.ClosePopUp();
            this.Close();
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
}
