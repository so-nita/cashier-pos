using CashierPOS.Model.Models.Constant;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_ReprintInvoice : Form
    {
        private readonly IParentView _parentView;
        public PopUp_ReprintInvoice(IParentView parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            InitializeComponentData();
        }

        private void btnCloseReprint_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }

        /*private void btnReprintByInvoice_Click(object sender, EventArgs e)
        {
            // Close the current form and its background
            this.Hide();
            PopUp_Background.ClosePopUp();
            // Create and show the PopUp_ReprintByInvoiceNo form
            var form = new PopUp_ReprintByInvoiceNo(_parentView);
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }*/
        private void btnReprintByInvoice_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PopUp_Background.Form.TopMost = false;
            // Close the current form's background
            PopUp_Background.ClosePopUp();

            // Create and show the PopUp_ReprintByInvoiceNo form
            var form = new PopUp_ReprintByInvoiceNo(_parentView);
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }


        private async void btnReprintByLast_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
            this.Close();

            var user = AppStoreContext.CurrentUser;
            var dataRequest = new ReprintInvoiceByLast()
            {
                //PosId = user.PosId,
                ShiftId = user.ShiftId,
            };
            var dataReturn = await GetDataFromInvoice(dataRequest);
            if (dataReturn != null)
            {
                /*PopUp_Background.ClosePopUp();
                this.Close();*/
                dataReturn.Total_Kh = CustomStyle.RoundUpCurrencyKh(dataReturn.Total_Kh);
                var form = new PopUp_Recipt(_parentView, dataReturn);
                PopUp_Background.Form = form;
                form.ShowInTaskbar = false;
                PopUp_Background.ShowPopUp();
            }
            else
            {
                MessageBox.Show("There is no invoice", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<SellInvoiceResponse> GetDataFromInvoice(ReprintInvoiceByLast dataRequest)
        {
            var service = new InvoiceService();
            var data = await service.CreateInvoiceByLast(dataRequest);
            return data?.Status == (int)ResponseStatus.Success ? data.Result! : null!;
        }

        
    }
}
