using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.View.View_PopUp;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using CashierPOS.UI.AppContexts;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_ReprintByInvoiceNo : Form
    {
        private IParentView _parentView;
        public PopUp_ReprintByInvoiceNo(IParentView parentView)
        {
            InitializeComponent();
            _parentView = parentView;
        }

        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            this.ActiveControl = txtboxInvoiceNo;
            InitializeEventHandeler();
        }

        // Function for button back form Reprint by No
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        // Function for Response Sell Invoice
        private async Task<SellInvoiceResponse> GetDataFromInvoice(ReprintInvoiceByNo dataRequest)
        {
            var service = new InvoiceService();
            var data = await service.CreateInvoiceByInvoiceNo(dataRequest);
            return data?.Status == (int)ResponseStatus.Success ? data.Result! : null!;
        }

        // Function for button Review
        private async void btnReview_Click(object sender, EventArgs e)
        {
            // Validation Before Review
            if (txtboxInvoiceNo.Text == " Scan or input" || txtboxInvoiceNo.Text == "")
            {
                txtboxMainInvoiceNo.ColorBackground_Pen = Color.Red;
            }
            else if (txtboxInvoiceNo.Text == txtboxInvoiceNo.Text)
            {
                var dataRequest = new ReprintInvoiceByNo()
                {
                    InvoiceNo = txtboxInvoiceNo.Text,
                    ShiftId = AppStoreContext.CurrentUser.ShiftId
                };

                var data = await GetDataFromInvoice(dataRequest);
                if (data != null)
                {
                    PopUp_Background.Form.TopMost = false;
                    PopUp_Background.ClosePopUp();
                    this.Close();
                   
                    if(data?.Status == OrderStatus.Return)
                    {
                        var returnForm = new PopUp_ReturnInvoice(_parentView, data);
                        PopUp_Background.Form = returnForm;
                        //returnForm.ShowInTaskbar = false;
                        PopUp_Background.ShowPopUp();
                        //returnForm.Shown += InvoiceShown;
                        return;
                    }
                    
                    var form = new PopUp_Recipt(_parentView, data!);
                    PopUp_Background.Form = form;
                    //form.ShowInTaskbar = false;
                    //form.IsPreview += InvoicePreview;
                    PopUp_Background.ShowPopUp();
                }
                else
                {
                    MessageBox.Show("Invoice not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtboxMainInvoiceNo.ColorBackground_Pen = Color.White;
            }
        }

        private void InvoicePreview(object? sender, EventArgs e)
        {
            this.TopMost = false;
        }

        // Function Close Form Reprint 
        private void btnCloseReprintbyNo_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }
    }
}
