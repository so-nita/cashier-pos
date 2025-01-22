using CashierPOS.Model.Models.Product;
using CashierPOS.UI.Components;
using CashierPOS.UI.Constant;
using CashierPOS.UI.Service;
using CashierPOS.UI.UserControls.ViewStock;
using CashierPOS.UI.View_PopUp;
using System.Data;

namespace CashierPOS.UI.View.ViewStock
{
    public partial class PopUp_ProductStock : Form
    {
        private readonly List<ProductResponse> _products = new ();
        private CustomTouchScroll _scrollProduct;

        public PopUp_ProductStock()
        {
            InitializeComponent();
            InitializeDataFromApi();
            _scrollProduct = new CustomTouchScroll(panelListproduct, ScrollDirection.Vertical);
        }

        private async void InitializeDataFromApi()
        {
            var productService = new ProductService();
            var products = await productService.GetAllAsync();
            _products.AddRange(products.OrderBy(e=>e.Qty));

            CretaeProductCard(_products);
            _scrollProduct.AssignScrollEvent(panelListproduct);
        }
        private void CretaeProductCard(List<ProductResponse> products)
        {
            foreach (var item in products)
            {
                var card = new UC_ProductStock(item);
                panelListproduct.Controls.Add(card);
            }
        }
        private List<ProductResponse> _searchItem { get; set; } = null!;

        public void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchItemInProductSell(textBoxSearch.Text);
            if (_searchItem.Count>0)
            {
                panelListproduct.Controls.Clear();

                foreach (var data in _searchItem)
                {
                    var userControl = new UC_ProductStock(data);
                    panelListproduct.Controls.Add(userControl);
                    _scrollProduct.AssignScrollEvent(panelListproduct);
                }
            }
        }

        private void SearchItemInProductSell(string text)
        {
            string searchText = text.Trim().ToLower();
            // Filter the Carts list based on the search criteria
            _searchItem = _products.Where(item =>
                item.Name.ToLower().Contains(searchText)
                || item.Code.ToLower().Contains(searchText)
                || (item.Description ?? "").ToLower().Contains(searchText)
                || (item.Size ?? "").ToLower().Contains(searchText)
            ).ToList();
        }
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }
    }
}
