using CashierPOS.Model.Models.Product;
using CashierPOS.UI.CustomStyles;

namespace CashierPOS.UI.UserControls;
public partial class UC_ProuductCard : UserControl
{
    public event EventHandler ProductClicked = null!;

    private ProductResponse _product;

    public ProductResponse Product
    {
        get { return _product; }
        set
        {
            _product = value;
        }
    }

    public UC_ProuductCard(ProductResponse product = null!)
    {
        InitializeComponent();
        InitializeLocation();
        InitializeComponentData();
        _product = product;
        InitData();
    }

    private async void InitData()
    {
        if (_product != null)
        {
            lbbarcodeItem.Text = _product.Code;
            labelNameItem.Text = _product.Name;
            labelPriceItem.Text = "$ " + _product.Price.ToString();
            labelSize.Text = _product.Size;

            if (_product.Qty <= 0)
            {
                UpdateOutStockProduct();
            }
            else
            {
                BtnStock(true);
                pictureItem.Click += pictureItem_Click!;
                btn_forBuy.Click += pictureItem_Click!;
                btnStock.ColorBackground = Color.FromArgb(16, 107, 67);
            }

            if (_product.DiscountPercent > 0)
            {
                ProductDiscount();
            }
            pictureItem.Image = await CustomStyle.GetImageFromUrl(_product.Image!);
        }
    }

    private void ProductDiscount()
    {
        lbDiscount.Visible = true;
        panelDisocount.Visible = true;
        //--lbDiscount.Text = _product.Discount.ToString() + " % Off";
        if (!IsDisposed)
        {
            lbDiscount.Text = _product.DiscountPercent.ToString() + " % Off";
        }
    }

    private void pictureItem_Click(object sender, EventArgs e)
    {
        ProductClicked?.Invoke(this, EventArgs.Empty);
    }

    private void UpdateOutStockProduct()
    {
        btnStock.ColorBackground = Color.Red;
    }

    private void BtnStock(bool isInStock = false)
    {
        // Update existing stock button properties instead of creating a new one each time
        btnStock.TextButton = isInStock ? "In Stock" : "Out Stock";
        btnStock.ColorBackground = isInStock ? Color.FromArgb(16, 107, 67) : Color.Red;
    }
}