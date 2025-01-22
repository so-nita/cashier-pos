using CashierPOS.UI.Components;
using CashierPOS.UI.Constant;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Testing;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_Recipt : Form
    {
        private IParentView _parentView;
        private SellInvoiceResponse _inovice = null!;
        private CustomTouchScroll _scrollHori;
        public event EventHandler IsPreview = null!;

        public PopUp_Recipt(IParentView parentView, SellInvoiceResponse invoiceData)
        {
            InitializeComponent();
            _parentView = parentView;
            _scrollHori = new CustomTouchScroll(panelReceipt, ScrollDirection.Vertical);
            if (invoiceData != null)
            {
                _inovice = invoiceData;
                InitializeInvoice();
            }
        }
        private void InitializeInvoice()
        {
            HideScrollBar();
            var inoviceform = new UC_SellInvoice(_inovice);
            inoviceform.RequestClose += Inoviceform_RequestClose!; // Subscribe to the event Close
            inoviceform.IsPreview += Inoviceform_RequestPreview!; // Subscribe to the event Preview

            //inoviceform.TabStop = true;
            panelReceipt.Controls.Add(inoviceform);
            inoviceform.Show();
            _scrollHori.AssignScrollEvent(inoviceform);
        }
        private void Inoviceform_RequestClose(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();

            _parentView.Carts.Clear();
            _parentView.ReturnOrder.Details!.Clear();
            _parentView.ViewPOS_LoadingData();
        }
        private void Inoviceform_RequestPreview(object sender, EventArgs e)
        {
            PopUp_Background.Form.TopMost = false;
            IsPreview?.Invoke(sender, e);
        }

        private void HideScrollBar()
        {
            panelReceipt.AutoScroll = false;
            panelReceipt.VerticalScroll.Maximum = 0;
            panelReceipt.VerticalScroll.Minimum = 0;
            panelReceipt.AutoScroll = true;
        }
 
    }
}
