using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CashierPOS.UI.CustomStyles;

public static class ExportPDF
{
    #region Export as PDF 
    private static string _filePath = "D:/invoice.pdf";
    public static void ExportPdfFile(UserControl userControl)
    {
        using (Document document = new Document())
        {
            //document.SetPageSize(iTextSharp.text.PageSize.A4);
            document.SetPageSize(new iTextSharp.text.Rectangle(userControl.Width + 60, userControl.Height - 65));
            PdfWriter.GetInstance(document, new System.IO.FileStream(_filePath, System.IO.FileMode.Create));
            document.Open();
            // Create an image from the UserControl
            Bitmap bitmap = new Bitmap(userControl.Width, userControl.Height);
            userControl.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, userControl.Width, userControl.Height));

            // Add the image to the PDF
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Bmp);
            document.Add(image);
            document.Close();

        }
        // Open the PDF file
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = _filePath,
            UseShellExecute = true
        });
    }
    #endregion
}

