using CashierPOS.Model.Models.ChangeShift;
using CashierPOS.UI.Components;
using CashierPOS.UI.UserControls;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_ReceiptSummary : Form
    {
        private CloseShiftSummaryRqsponse _inovice { get; set; }
        private CustomTouchScroll _scroll; 

        public PopUp_ReceiptSummary(CloseShiftSummaryRqsponse invoiceData = null!)
        {
            InitializeComponent();
            _scroll = new CustomTouchScroll(panelReceipt, Constant.ScrollDirection.Vertical);

            if (invoiceData != null)
            {
                _inovice = invoiceData;
            }
            InitializeInvoice();
        }

        private void InitializeInvoice()
        {
            HideScrolBar();
            /*var service = new ChangeShiftService();
            var data = await service.CreateReceiptSummaryCloseShift("663");*/

            var userControl = new UC_ReciepSummary(_inovice);
            panelReceipt.Controls.Add(userControl);
            var userControlHeight = userControl.Height;
            this.Height = userControlHeight;    
            userControl.Show();
            userControl.RequestCloseView += UserControl_RequestCloseView;
            _scroll.AssignScrollEvent(userControl);
        }

        private void UserControl_RequestCloseView(object? sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private void HideScrolBar()
        {
            panelReceipt.AutoScroll = false;
            panelReceipt.VerticalScroll.Maximum = 0;
            panelReceipt.VerticalScroll.Minimum = 0;
            panelReceipt.AutoScroll = true;
        }
    }
}
