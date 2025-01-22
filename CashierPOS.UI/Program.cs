using CashierPOS.UI.View;
using CashierPOS.UI.View_PopUp;

namespace CashierPOS.UI;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);

        var form = new View_POS(new View_Main())
        {
            StartPosition = FormStartPosition.CenterParent,
            WindowState = FormWindowState.Maximized,
        };

        form.BringToFront();
        PopUp_Background.Form = form;

        //var form = new TestingForm();

        /*var service = new ChangeShiftService();
        var data = service.CreateReceiptSummaryCloseShift("291");
        var dataRespose = data.Result.Result;
        var form = new PopUp_ReceiptSummary(dataRespose!);*/

        /*var dataRes = new OrderCreateReq()
        {
            Order_Status = CashierPOS.Model.Models.Constant.OrderStatus.Close,
            OrderDetails = new List<OrderDetailCreateReq>()
            {
                new OrderDetailCreateReq() {Price=2, Qty=2, Discount_Amount=0, Discount_Percent=0, Status=CashierPOS.Model.Models.Constant.OrderItemStatus.Close},
                new OrderDetailCreateReq() {Price=2.2m, Qty=2, Discount_Amount=0, Discount_Percent=0, Status=CashierPOS.Model.Models.Constant.OrderItemStatus.Close},
                new OrderDetailCreateReq() {Price=3, Qty=1, Discount_Amount=0, Discount_Percent=0, Status=CashierPOS.Model.Models.Constant.OrderItemStatus.Close},
            }
        };
        var form = new PopUp_PaymentOption(new View_POS(new View_Main()), dataRes);*/

        //var form = new PopUp_CloseShift();

        /*var form = new View_Main();
        form.WindowState = FormWindowState.Maximized;*/

        Application.Run(form);
    }
}