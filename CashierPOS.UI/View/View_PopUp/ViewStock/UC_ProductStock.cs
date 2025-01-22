using CashierPOS.Model.Models.Product;
using CashierPOS.UI.CustomStyles;
using CashierPOS.WebApi.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

namespace CashierPOS.UI.UserControls.ViewStock
{
    public partial class UC_ProductStock : UserControl
    {
        public event EventHandler ProductClicked;

        private ProductResponse _product;

        public ProductResponse Product
        {
            get { return _product; }
            set
            {
                _product = value;
            }
        }
        public UC_ProductStock(ProductResponse product = null!)
        {
            InitializeComponent();
            _product = product;
            InitData();
        }
        private async void InitData()
        {
            if (_product != null)
            {
                lblName_item.Text = _product.Name;
                lbbarcodeItem.Text = _product.Code;
                lblQty.Text = _product.Qty.ToString();
                pictureItem.Image = await CustomStyle.GetImageFromUrl(_product.Image!);
            }
        }
    }
}
