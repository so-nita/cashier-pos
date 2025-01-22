using System.Drawing.Printing;


namespace CashierPOS.UI.CustomStyles
{
    public static class Printer
    {
        #region For Print sell receipt 
        public static void PrintReceipt(UserControl userControl)
        {
            PrintDocument pd = new PrintDocument();
            //pd.DefaultPageSettings.PaperSize = new PaperSize("A6", (int)(4.13 * 100), userControl.Height);
            pd.DefaultPageSettings.PaperSize = new PaperSize("CustomSize", userControl.Width + 20, userControl.Height + 10);

            pd.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(userControl.Width, userControl.Height);
                userControl.DrawToBitmap(bitmap, new Rectangle(0, 0, userControl.Width, userControl.Height));
                e.Graphics!.DrawImage(bitmap, Point.Empty);
            };
            pd.Print();
        }
        #endregion


        #region For Open Cash Drawer 
        public static void OpenCashDrawer()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) => { };
            pd.Print();
        }
        #endregion

    }
}
