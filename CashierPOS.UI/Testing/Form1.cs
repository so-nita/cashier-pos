using CashierPOS.Model.Models.ReasonType;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.Service;
using CashierPOS.UI.Testing;
using CashierPOS.UI.View_PopUp;
using Syncfusion.Pdf.Graphics;
using PdfDocument = Syncfusion.Pdf.PdfDocument;
using PdfFont = Syncfusion.Pdf.Graphics.PdfFont;
using PdfPage = Syncfusion.Pdf.PdfPage;

namespace TestReceipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private async void Initialize()
        {
            var service = new ReasonTypeService();
            var data = await service.GetReasonType();

            comboBoxReason.DisplayMember = "Name";
            comboBoxReason.ValueMember = "Id";  

            comboBoxReason.Items.Add(new ReasonTypeResponse() { Id = "0", Name = " -- Select -- " });

            foreach (var item in data)
            {
                comboBoxReason.Items.Add(item);
            }

            comboBoxReason.SelectedIndex = 0;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckIsSelectReason())
            {
                MessageBox.Show("Failed"); return;
            }
            //MessageBox.Show("Ok");
            Export();
        }

        private bool CheckIsSelectReason()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control == comboBoxReason)
                {
                    var selectItem = comboBoxReason.SelectedItem as ReasonTypeResponse;   
                    if (selectItem == null || selectItem.Id=="0")
                    {
                        txtboxMainReason.ColorBackground_Pen = Color.Red;
                    }
                    else
                    {
                        txtboxMainReason.ColorBackground_Pen = Color.FromArgb(47, 155, 70);
                    }
                    break;
                }
            }
            return true;
        }

        private async void exportPDF_Click(object sender, EventArgs e)
        {
            //Printer.ExportAsPdf();
            //export.ExportPdfFile(user);
            var service = new InvoiceService();
            /*var data = await service.GetAsync("101-01-240000397");
            var invoice = new UC_SellInvoice(data);
            ExportPDF.ExportPdfFile(invoice);*/
        }

        private void Export()
        {
            //Create a new PDF document. 
            using (PdfDocument document = new PdfDocument())
            {
                //Add a page to the document.
                PdfPage page = document.Pages.Add();
                //Create PDF graphics for a page.
                PdfGraphics graphics = page.Graphics;
                //Set the standard font.
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
                //Draw the text.
                graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, new PointF(0, 0));
                //Save the document.
                document.Save("Output.pdf");
            }
        }
    }


}
