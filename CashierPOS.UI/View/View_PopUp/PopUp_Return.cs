using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Interface;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_Return : Form
    {
        private readonly IParentView _parentView = null!;
        public event EventHandler<bool> IsCancelReturn = null!;
        public PopUp_Return(IParentView parentView = null!)
        {
            InitializeComponent();
            InitializeReasonReturnData();

            if (parentView != null)
            {
                _parentView = parentView;
            }
        }

        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            this.ActiveControl = txtboxInvoiceNo;
            InitializeEventHandeler();
        }

        //Function Cancel Return Form
        private void btnCancle_Click(object sender, EventArgs e)
        {
            PopUp_Background.Form = this;
            PopUp_Background.ClosePopUp();
            IsCancelReturn(sender, true);
            this.Close();
            //_parentView.ViewPOS_LoadingData();
        }

        private List<ReasonReturnTypeResponse> selectReason = null!;

        //Function for select Reason Return form
        private async void InitializeReasonReturnData()
        {
            var service = new ReasonReturnTypeService();
            selectReason = await service.GetAllAsync();

            comboBoxReason.DisplayMember = "Name";
            comboBoxReason.ValueMember = "Id";

            comboBoxReason.Items.Add(new ReasonReturnTypeResponse() { Id = "0", Name = "Select The Reason" });

            foreach (var item in selectReason)
            {
                comboBoxReason.Items.Add(item);
            }
            comboBoxReason.SelectedIndex = 0;
        }

        private async void GetValueReturn()
        {
            string ResonTypeId = "";
            if (comboBoxReason.SelectedItem != null)
            {
                var selectItem = comboBoxReason.SelectedItem as ReasonReturnTypeResponse;
                if (selectItem != null)
                {
                    ResonTypeId = selectItem.Id;
                }
            }

            var returnService = new OrderService();

            var productCode = (txtboxBarCode.Text != txtboxBarCode?.Tag!.ToString() && txtboxBarCode?.Text.Trim() != "") ? txtboxBarCode?.Text.Trim() : null;
            var userApproved = AppStoreContext.CurrentUserApprove;
            var dataReturn = new OrderReturnReq()
            {
                InvoiceNo = txtboxInvoiceNo.Text.Trim().ToString(),
                ProductCode = productCode,
                ReasonReturnId = ResonTypeId,
                ApprovedByUserId = userApproved.UserId
            };

            var item = await returnService.GetReturnOrder(dataReturn);
            if (item != null)
            {
                if (item?.Status == (int)ResponseStatus.Success)
                {
                    _parentView.ReturnOrder = item.Result!;

                    PopUp_Background.ClosePopUp();
                    _parentView.ViewPOS_LoadingData();
                }
                else
                {
                    MessageBox.Show(item?.Message ?? "Something went wrong !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invoice not found !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Function for search Return form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errorData = new List<CyberTextBox>();
            if (txtboxInvoiceNo.Text == "Scan or input" || txtboxInvoiceNo.Text == "")
            {
                errorData.Add(txtboxInvoiceNoMain);
            }
            var selectItem = comboBoxReason.SelectedItem as ReasonReturnTypeResponse;
            if (selectItem == null || selectItem.Id == "0")
            {
                errorData.Add(txtboxMainReason);
            }

            if (errorData.Count > 0)
            {
                bool isInvoiceNoError = false;
                bool isReasonError = false;
                foreach (var item in errorData)
                {
                    if (item.Name == txtboxInvoiceNoMain.Name)
                    {
                        txtboxInvoiceNoMain.ColorBackground_Pen = Color.Red;
                        isInvoiceNoError = true;
                    }
                    else if (item.Name == txtboxMainReason.Name)
                    {
                        txtboxMainReason.ColorBackground_Pen = Color.Red;
                        isReasonError = true;
                    }
                }
                if (!isInvoiceNoError)
                {
                    txtboxInvoiceNoMain.ColorBackground_Pen = Color.White;
                }
                if (!isReasonError)
                {
                    txtboxMainReason.ColorBackground_Pen = Color.White;
                }
            }
            else
            {
                txtboxInvoiceNoMain.ColorBackground_Pen = Color.White;
                //txtboxMainReason.ColorBackground_Pen = Color.White;
                txtboxMainReason.ColorBackground_Pen = Color.FromArgb(176, 215, 181);
                GetValueReturn();
            }
        }

        //Function Close Form Return
        private void btnCloseReturn_Click(object sender, EventArgs e)
        {
            IsCancelReturn(sender, true);
            PopUp_Background.ClosePopUp();
        }

        private void comboBoxReason_Click(object sender, EventArgs e)
        {
            if (comboBoxReason.SelectedItem != null)
            {
                // Check if the selected item is of type GiftCouponResponse
                if (comboBoxReason.SelectedItem is ReasonReturnTypeResponse selectItem)
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