using ReaLTaiizor.Controls;
using CashierPOS.UI.UserControls;
using CashierPOS.UI.Components;
using CashierPOS.UI.Constant;
using CashierPOS.UI.Service;
using CashierPOS.Model.Models.Product;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.Constant;
using CashierPOS.UI.Interface;
using CashierPOS.UI.View_PopUp;
using CashierPOS.UI.AppContexts;
using CashierPOS.UI.View.View_PopUp;
using CashierPOS.Model.Models.User;
using CashierPOS.Model.Models.Brand;
using CashierPOS.WebApi.Models.RequestModel.Order.OrderDetail;
using CashierPOS.Model.Models.Division;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CashierPOS.UI.View
{
    public partial class View_POS : Form, IParentView
    {
        private IMainView _mainView;
        public readonly List<ProductResponse> Products = new();
        //private List<CategoryResponse> Categories = new List<CategoryResponse>();
        private List<DivisionResponse> Divisions = new ();
        public List<ProductResponse> Carts { get; set; } = new List<ProductResponse>();
        public ReturnOrderResponse ReturnOrder { get; set; } = new();

        public View_POS(IMainView parentView)
        {
            _mainView = parentView;
            InitializeComponent();
            InitializeData();
        }

        public void ViewPOS_LoadingData()
        {
            var data = new List<ProductResponse>();
            if (Carts?.Count > 0 && ReturnOrder.Details!.Count == 0)
            {
                data = Carts.Where(e => e.Status == OrderItemStatus.Close.ToString()).ToList();
            }
            else if (ReturnOrder.Details?.Count > 0)
            {
                Carts = ReturnOrder.Details.Where(e => e.Status != OrderItemStatus.Cancel).Select(e => new ProductResponse()
                {
                    Price = e.Price,
                    Id = e.Product_Id,
                    Code = e.Product_Code,
                    Qty = e.Qty,
                    Name = e.Product_Name,
                    Image = e.Product_Image,
                    DiscountPercent = e.Discount_Percent,
                    DiscountAmount = e.Discount_Amount,
                    Status = e.Status.ToString(),
                }).ToList()!;
                data = Carts;
            }
            panelCart.Controls.Clear();
            foreach (var item in data)
            {
                var productForCart = new UC_ProuductForCart(GetOrderDetail(item), this);
                productForCart.panelCard.Click += ProductInCart_Selected;
                productForCart.picProduct.Click += ProductInCart_Selected;
                panelCart.Controls.Add(productForCart);
                panelCart.Controls.SetChildIndex(productForCart, 0);
                _scrollPanelCart.AssignScrollEvent(productForCart);
            }
            UC_FooterTotal.CalculateTotal(data);
            ReloadNotificationHoldOrder();
            var canPay = data.Where(e => e.Status != OrderItemStatus.Cancel.ToString()).Count() > 0;
            EnablePayment(canPay);
            UC_AllButton.UpdateButtonDisableForReturn();
        }

        public List<ProductResponse> GetProducts => Products;

        private void InitializeData()
        {
            InitializeDataComponent();
            _scrollPanelCart = new CustomTouchScroll(panelCart, ScrollDirection.Vertical);
            productTouchScroll = new CustomTouchScroll(panelCategory, ScrollDirection.Horizontal);
            HideCategoryScrollBar();
            InitializeDataFromApi();
            InitbuttonAllCategory();
            UpdateNumberOfHoldOrder();
        }

        private int PageIndex { get; set; } = 1;

        private async void InitializeDataFromApi()
        {
            panelListproduct.Controls.Clear();
            panelCategory.Controls.Clear();
            Products.Clear();
            Divisions.Clear();
            //var serviceCategory = new SubCategoryService();
            //var categories = await serviceCategory.GetAllAsync();
            var divisionSer = new DivisionService();
            var divisions = await divisionSer.GetAllAsync();
            var productService = new ProductService();
            var products = await productService.GetAllAsync();
            Products.AddRange(products);
            //Categories = categories.Where(e => Products.Any(p => p.Id == e.Id)).OrderBy(e => e.Name).ToList();
            Divisions = divisions.Where(e => Products.Any(p => p.Division_Id == e.Id)).OrderBy(e => e.Name).ToList();
            foreach (var /*category*/ division in Divisions /*Categories*/)
            {
                CreateButtonCategory(division/*category*/);
            }
            //InitListDivisions(Divisions);
            InitListProduct(PageIndex, Products);
            InitailizeProductBrandData();
        }

        /*private void InitListDivisions(List<DivisionResponse> divisions)
        {
            panelCategory.Controls.Clear();
            InitbuttonAllCategory();
            foreach (var division in divisions)
            {
                CreateButtonCategory(division);
            }
        }*/
        private void InitailizeProductBrandData()
        {
            _listProductBrands.Clear();
            /* var service = new BrandService();
            _listProductBrands = await service.GetAllAsync();*/
            _listProductBrands = Products.DistinctBy(e => e.Brand).Where(e=> !e.Brand.IsNullOrEmpty()).Select(b => new BrandResponse()
            {
                Name = b.Brand!,
            }).OrderBy(e=>e.Name).ToList();
            comboBrand.Items.Add(new BrandResponse { Name = "Select All Brand", Code = 0 });

            foreach (var item in _listProductBrands)
            {
                comboBrand.Items.Add(item);
            }
            // Set the DisplayMember and ValueMember properties
            comboBrand.DisplayMember = "Name"; // Display the brand name
            comboBrand.ValueMember = "Name";
            comboBrand.SelectedIndex = 0;
        }
        public async void UpdateProductData()
        {
            Products.Clear();
            panelListproduct.Controls.Clear();
            var productService = new ProductService();
            var products = await productService.GetAllAsync();
            Products.AddRange(products);
        }
        private void GetProductByCategory(object sender, /*CategoryResponse category*/ DivisionResponse division)
        {
            var productsByCategory = Products.Where(e => e./*Sub_Category_Id*/Division_Id == /*category*/ division.Id).ToList();
            CretaeProductCard(productsByCategory);
            ActiveButtonOnClicked(sender);
            PopulatePager(productsByCategory.Count, PageIndex = 1);
        }

        private void InitListProduct(int pageIndex, List<ProductResponse> products)
        {
            PopulatePager(products.Count, pageIndex);
            CretaeProductCard(products);
        }

        private void CretaeProductCard(List<ProductResponse> products)
        {
            panelListproduct.Controls.Clear();
            var xOffSet = 0;
            int startIndex = (PageIndex - 1) * itemPerPage;
            int endIndex = Math.Min(startIndex + itemPerPage, products.Count);
            for (int i = startIndex; i < endIndex; i++)
            {
                var card = new UC_ProuductCard(products[i]);
                card.Location = new Point(xOffSet, 0);
                card.ProductClicked += UC_ProuductCard_ProductClicked!;
                panelListproduct.Controls.Add(card);
                xOffSet += 195;
            }
        }

        private void UC_ProuductCard_ProductClicked(object sender, EventArgs e)
        {
            if (sender is UC_ProuductCard productCard)
            {
                // test date 01-03-2024
                if (ReturnOrder?.Details?.Count > 0)
                {
                    return;
                }
                //end test
                var product = productCard.Product;
                AddProductToCart(product);
                EnablePayment(true);
            }
        }

        public void EnablePayment(bool canPay)
        {
            UC_AllButton.UC_AllButton_Load(canPay);
        }

        private void AddProductToCart(ProductResponse product)
        {
            var existingProduct = Carts.FirstOrDefault(e => e.Id == product.Id);

            if (existingProduct == null)
            {
                var newProduct = new ProductResponse()
                {
                    Qty = 1,
                    Id = product.Id,
                    Status = OrderItemStatus.Close.ToString(),
                    Code = product.Code,
                    Name = product.Name,
                    Image = product.Image,
                    Price = product.Price,
                    DiscountAmount = product.DiscountAmount,
                    DiscountPercent = product.DiscountPercent,
                };
                Carts.Add(newProduct);
                CreateProductToCart(newProduct);
            }
            else
            {
                var productQty = Products.First(e => e.Id == existingProduct.Id).Qty;
                if (productQty > existingProduct.Qty)
                {
                    UpdateQtyProductCart(existingProduct);
                }
                else
                {
                    MessageBox.Show("Stock item is limit", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UC_FooterTotal.CalculateTotal(Carts);
            UC_AllButton.ButtonClick += BtnPayment_Click;
        }

        private void UpdateQtyProductCart(ProductResponse existingProduct)
        {
            if (existingProduct.Status == OrderItemStatus.Close.ToString())
            {
                // If the existing product is already in the cart with status Close, increase its quantity
                existingProduct.Qty += 1;
                foreach (Control control in panelCart.Controls)
                {
                    if (control is UC_ProuductForCart productForCart && productForCart.GetProduct.Product_Id == existingProduct.Id)
                    {
                        productForCart.GetProduct.Qty = existingProduct.Qty;
                        productForCart.UpdateQuantity();
                    }
                }
            }
            else
            {
                // If the existing product is already in the cart with status Cancel, uppdate product data as defualt to Carts
                existingProduct.Qty = 1;
                existingProduct.DiscountPercent = 0;
                existingProduct.DiscountAmount = 0;
                existingProduct.Status = OrderItemStatus.Close.ToString();
                existingProduct.ReasonCode = null;
                CreateProductToCart(existingProduct);
            }
        }

        // Create Product in Cart 
        private void CreateProductToCart(ProductResponse product)
        {
            var productForCart = new UC_ProuductForCart(GetOrderDetail(product), this);
            productForCart.panelCard.Click += ProductInCart_Selected;
            productForCart.picProduct.Click += ProductInCart_Selected;
            /*if(productForCart.GetProduct.Discount_Percent <= 0 )
            {
                productForCart.panelCard.Click += ProductInCart_Selected;
                productForCart.picProduct.Click += ProductInCart_Selected;
            }*/
            panelCart.Controls.Add(productForCart);
            panelCart.Controls.SetChildIndex(productForCart, 0);
            // For scroll on product list in panel cart 
            _scrollPanelCart.AssignScrollEvent(productForCart);
        }

        private OrderDetailResponse GetOrderDetail(ProductResponse product)
        {
            var discountAmount = (product.DiscountAmount != 0 && product.DiscountAmount != null) ? product.DiscountAmount
                               : (product.DiscountPercent * product.Price) / 100;

            var totalDiscount = (discountAmount ?? 0) * product.Qty;

            var dataResp = new OrderDetailResponse
            {
                Price = product.Price,
                Product_Code = product.Code,
                Product_Name = product.Name,
                Discount_Amount = totalDiscount /*discountAmount*/,
                Total_Discount = totalDiscount,
                Discount_Percent = product.DiscountPercent ?? 0,
                Grand_Amount = (product.Price * product.Qty) - totalDiscount /*(product.Qty * discountAmount??0)*/,
                Qty = product.Qty,
                Product_Id = product.Id,
                Product_Image = product.Image,
                ReasonCode = product.ReasonCode,
                Size = product.Size,
                Status = Enum.Parse<OrderItemStatus>(product.Status, true),
                Sub_Amount = product.Price * product.Qty,
            };
            return dataResp;
        }

        private void BtnPayment_Click(object? sender, EventArgs e)
        {
            var orderStatus = OrderStatus.Close;
            if (UC_AllButton.IsReturnMode && ReturnOrder.Details.Count > 0)
            {
                orderStatus = OrderStatus.Return;
                UC_AllButton.DataReturnOrder = ReturnOrder;
            }
            else
            {
                var currentUser = AppStoreContext.CurrentUser;
                UC_AllButton.IsReturnMode = false;
                UC_AllButton.Data = new OrderCreateReq()
                {
                    //--Tax = 0,
                    ShiftId = currentUser.ShiftId,
                    Order_Status = orderStatus,
                    DeleveryFee = 0,
                    //DeleveryFeeKh = 0,
                    OrderDetails = Carts?.Select(e => new OrderDetailCreateReq()
                    {
                        Discount_Amount = e.DiscountAmount,
                        Discount_Percent = e.DiscountPercent,
                        Status = Enum.Parse<OrderItemStatus>(e.Status),
                        ReasonCode = e.ReasonCode,
                        Product_Id = e.Id,
                        Price = e.Price,
                        Qty = e.Qty,
                    }).ToList()!
                };
            }
        }

        private void HideCategoryScrollBar()
        {
            panelCategory.VerticalScroll.Maximum = 0;
            panelCategory.HorizontalScroll.Maximum = 0;
            panelCategory.AutoScroll = true;
        }
        private void BtnAllCategory_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                ActiveButtonOnClicked(sender);
            }
            //InitializeDataFromApi();
            InitListProduct(PageIndex, Products);
        }

        private int itemPerPage = 21;

        private void Page_Click(object sender, EventArgs e)
        {
            HopeButton btnPager = (sender as HopeButton)!;
            PageIndex = int.Parse(btnPager.Name);
            InitListProduct(int.Parse(btnPager.Name), Products);
        }

        // Payment 
        private LostButton lastClickedButton = new();
        private void CategoryActiveButton(LostButton button, Color backgroundColor, Color textColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = textColor;
        }

        private void ActiveButtonOnClicked(object sender)
        {
            CategoryActiveButton(lastClickedButton, Color.FromArgb(16, 107, 67), Color.White);

            if (sender is LostButton btnClicked)
            {
                lastClickedButton = btnClicked;
                lbNewItem.Text = lastClickedButton.Text;

                if (lastClickedButton != null)
                {
                    CategoryActiveButton(lastClickedButton, Color.FromArgb(56, 56, 56), Color.White);
                }
            }
        }
        public void CloseView()
        {
            AppStoreContext.ClearCurrentUser();
            this.Close();
            PopUp_Background.ClosePopUp();
            _mainView.CloseView();
        }

        private List<BrandResponse> _listProductBrands = new List<BrandResponse>();

        private void btnHome_Click(object sender, EventArgs e)
        {
            InitializeDataFromApi();
            InitbuttonAllCategory();
        }

        private UserLogResponse _currentUser;

        private UserLogResponse GetCurrentUser
        {
            get
            {
                if (_currentUser != null)
                {
                    return _currentUser;
                }
                return _currentUser = AppStoreContext.CurrentUser;
            }
        }

        public HoldOrderResponse HoldOrder { get; set; }

        private async Task<List<HoldOrderResponse>> GetHoldOrder()
        {
            var service = new OrderService();

            var dataRequest = new HoldOrderGetRequest()
            {
                //PosId = GetCurrentUser.PosId,
                ShiftId = GetCurrentUser.ShiftId,
            };
            var dataResponse = await service.GetAllHoldOrderAsync(dataRequest);
            if (dataResponse != null)
            {
                // if current hold holder has so -1 of hold order
                NumberHoldOrder = HoldOrder == null ? dataResponse.Count : dataResponse.Count - 1;
                ReloadNotificationHoldOrder();
                return dataResponse;
            }
            return null!;
        }

        public async Task UpdateNumberOfHoldOrder()
        {
            await GetHoldOrder();
        }

        public void ReloadNotificationHoldOrder()
        {
            btnHoldCart.NotificationCount = NumberHoldOrder;
        }
        private async void btnShowCart_Click(object sender, EventArgs e)
        {
            var holdOrder = await ShowOrderInHoldCart();
            if (holdOrder != null)
            {
                SowPopUpHoldOrder(holdOrder);
            }
        }

        private async void pictureBoxHoldCart_Click(object sender, EventArgs e)
        {
            var holdOrder = await ShowOrderInHoldCart();
            if (holdOrder != null)
            {
                SowPopUpHoldOrder(holdOrder);
            }
        }
        //Function For Click on Button Hold
        private async Task<List<HoldOrderResponse>> ShowOrderInHoldCart()
        {
            if (ReturnOrder.Details!.Any()) return null!; // if begin return cannot 

            var dataResponse = await GetHoldOrder();
            var data = new List<HoldOrderResponse>();
            if (dataResponse?.Count > 0)
            {
                if (HoldOrder?.OrderDetails?.Count > 0)
                {
                    data = dataResponse.Where(e => e.OrderId != HoldOrder.OrderId).ToList();
                }
                else
                {
                    data = dataResponse;
                }
                if (data.Count <= 0)// if number of hold is 0 no need to show popup hold order 
                {
                    NumberHoldOrder = 0;
                    ReloadNotificationHoldOrder();
                    return data;
                }

                return data;
            }
            return null!;
        }
        private void SowPopUpHoldOrder(List<HoldOrderResponse> data)
        {
            var form = new PopUp_HoldOrder(this, data);
            form.ReHoldOrderClicked += Form_ReHoldOrderClicked;
            form.IsRecartClicked += Form_IsRecartClicked;
            form.ShowInTaskbar = false;
            PopUp_Background.Form = form;
            PopUp_Background.ShowPopUp();
        }
        private async void Form_ReHoldOrderClicked(object? sender, bool isRecart)
        {
            if (isRecart)
            {
                NumberHoldOrder--;
                await UC_AllButton.ReHoldOrderAsync();
            }
        }

        private async void Form_IsRecartClicked(object? sender, bool isRecart)
        {
            if (isRecart)
            {
                /*NumberHoldOrder--;
                btnHoldCart.NotificationCount = NumberHoldOrder;*/
                await ShowOrderInHoldCart();
            }
        }

        // Search Item 
        private ProductResponse _searchItem { get; set; } = new ();
        private void SearchItemInCart(string text)
        {
            string searchText = text.Trim().ToLower();
            // Filter the Products list based on the search criteria
            _searchItem = Products.FirstOrDefault(item =>
                item.Name.ToLower() == searchText || item.Code.ToLower() == searchText);
        }

        private void TxtSearchItemInCart_TextChanged(object sender, EventArgs text)
        {
            _searchItem = null!;
            SearchItemInCart(txtSearchItemInCart.Text);
            if (_searchItem != null)
            {
                _searchItem.Status = OrderItemStatus.Close.ToString();
                AddProductToCart(_searchItem);
                txtSearchItemInCart.SelectAll();
                EnablePayment(true);
            }
        }

        private List<ProductResponse> _searchProductSell { get; set; } = new();
        public int NumberHoldOrder { get; set; } = 0;
        public string ProductApplyDiscount { get; set; }

        public void TxtSearchItemInProductSell_TextChanged(string searchValue)
        {
            SearchItemInProductSell(searchValue);
            // Suspend the layout logic
            panelListproduct.SuspendLayout();
            panelListproduct.Controls.Clear();

            if (_searchProductSell.Any())
            {
                /*foreach (var item in _searchProductSell)
                {
                    var userControl = new UC_ProuductCard(item);
                    userControl.ProductClicked += UC_ProuductCard_ProductClicked!;
                    panelListproduct.Controls.Add(userControl);
                }*/
                InitListProduct(PageIndex, _searchProductSell);
            }
            // Resume the layout logic
            panelListproduct.ResumeLayout();
        }

        private void SearchItemInProductSell(string searchValue)
        {
            string searchText = searchValue.Trim().ToLower();
            // Filter the Carts list based on the search criteria
            _searchProductSell = Products.Where(item =>
                item.Name.ToLower().StartsWith(searchText)
                || item.Code.ToLower().Contains(searchText)
                /*|| (item.Description ?? "").ToLower().Contains(searchText)
                || (item.Size ?? "").ToLower().Contains(searchText)*/
            ).ToList();
        }

        public void LoadDataApi()
        {
            //InitbuttonAllCategory();
            InitializeDataFromApi();
            InitbuttonAllCategory();
        }

        /*public void UserClosedShift()
        {
            this.Close();
            _mainView.AddController(new view_Content_Cashier(_mainView));
            //PopUp_Background.ClosePopUp();
        }*/
    }
}
public class Page
{
    public string Text { get; set; } = "";
    public string Value { get; set; } = "";
    public bool Selected { get; set; }
}

