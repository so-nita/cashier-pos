using CashierPOS.Model.Models.Brand;
using CashierPOS.Model.Models.Category;
using CashierPOS.Model.Models.Division;
using CashierPOS.Model.Models.Product;
using CashierPOS.UI.Components;
using CashierPOS.UI.CustomStyles;
using CashierPOS.UI.UserControls;
using Newtonsoft.Json.Linq;
using System.Text;
using TestReceipt;

namespace CashierPOS.UI.View
{
    partial class View_POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        protected void InitializeDataComponent()
        {
            this.ActiveControl = txtSearchItemInCart;
            InitDataFooter();
            InitDataNavigation();
        }

        
        protected void InitbuttonAllCategory()
        {
            var btnAllCategory = new ReaLTaiizor.Controls.LostButton();
            btnAllCategory.BackColor = Color.FromArgb(16, 107, 67);
            btnAllCategory.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllCategory.ForeColor = Color.White;
            btnAllCategory.HoverColor = Color.FromArgb(56, 56, 56);
            btnAllCategory.Size = new Size(140, 40);
            btnAllCategory.Text = "All Category";
            btnAllCategory.Click += BtnAllCategory_Click!;
            panelCategory.Controls.Add(btnAllCategory);
            // Active Button AllCategory
            lastClickedButton = btnAllCategory;
            ActiveButtonOnClicked(btnAllCategory);
        }

        private void CreateButtonCategory(/*CategoryResponse*/ DivisionResponse item)
        {
            var btnCategory = new ReaLTaiizor.Controls.LostButton();
            btnCategory.BackColor = Color.FromArgb(16, 107, 67);
            btnCategory.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.White;
            btnCategory.HoverColor = Color.FromArgb(56, 56, 56);
            btnCategory.Size = new Size(150,40);
            btnCategory.Text = item.Name;
            btnCategory.Click += (sender, e) => GetProductByCategory(sender!, item);
            panelCategory.Controls.Add(btnCategory);
            productTouchScroll.AssignScrollEvent(btnCategory);
        }

        #region Pagination Button 
        private void PopulatePager(int numberItem, int currentPage)
        {
            List<Page> pages = new List<Page>();
            int startIndex, endIndex;
            decimal totalPage = numberItem / itemPerPage;
            //--int pagerSpan = itemPerPage;
            int pagerSpan = numberItem / itemPerPage;

            double dblPageCount = (double)((decimal)numberItem / Convert.ToDecimal(PageIndex));
            //-- int pageCount = (int)Math.Ceiling(dblPageCount);
            //-- int pageCount = (int)Math.Ceiling(totalPage);
            int pageCount = (int)Math.Ceiling((double)numberItem / itemPerPage);

            startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
            endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
            if (currentPage > pagerSpan % 2)
            {
                if (currentPage == 2)
                {
                    endIndex = 5;
                }
                else
                {
                    endIndex = currentPage + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - currentPage) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > pageCount)
            {
                endIndex = pageCount;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }

            //Add the Previous Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "<", Value = (currentPage - 1).ToString() });
            }

            for (int i = 1; i <= pageCount /*endIndex*/; i++)
            {
                pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
            }

            //Add the Next Button.
            if (currentPage < pageCount)
            {
                pages.Add(new Page { Text = ">", Value = (currentPage + 1).ToString() });
            }

            //Clear existing Pager Buttons.
            pnlPager.Controls.Clear();

            //Loop and add Buttons for Pager.
            int count = 0;
            foreach (Page page in pages)
            {
                var btnPage = new ReaLTaiizor.Controls.HopeButton();
                btnPage.BackColor = Color.White;
                btnPage.BorderColor = Color.FromArgb(70, 84, 69);
                btnPage.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
                btnPage.DangerColor = Color.FromArgb(245, 108, 108);
                btnPage.DefaultColor = Color.FromArgb(255, 255, 255);
                btnPage.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
                btnPage.HoverTextColor = Color.DarkBlue;
                btnPage.InfoColor = Color.FromArgb(144, 147, 153);
                btnPage.Location = new Point(594, 116);
                btnPage.PrimaryColor = Color.White;
                btnPage.Size = new Size(25, 25);
                btnPage.SuccessColor = Color.FromArgb(103, 194, 58);
                btnPage.Location = new Point(38 * count, 5);
                btnPage.Name = page.Value;
                btnPage.Text = page.Text;
                btnPage.TextColor = Color.FromArgb(16, 107, 67);
                btnPage.Enabled = !page.Selected;
                btnPage.Click += new System.EventHandler(this.Page_Click!);
                pnlPager.Controls.Add(btnPage);
                count++;
            }
        }
        #endregion
        // Data in Footer 
        private void InitDataFooter()
        {
            UC_FooterTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UC_FooterTotal.Location = new Point(3, 3);
            UC_FooterTotal.Name = "UC_FooterTotal";
            UC_FooterTotal.Size = new Size(383, 140);

            UC_AllButton = new UC_AllButton(_mainView, this);
            UC_AllButton.BackColor = Color.Transparent;
            UC_AllButton.Location = new Point(3, 149);
            UC_AllButton.Name = "uC_AllButton1";
            UC_AllButton.Size = new Size(389, 104);
            UC_AllButton.TabIndex = 1;
            panelFooterHover.Controls.Add(UC_AllButton);
        }

        // Data in Navigation button 
        private void InitDataNavigation()
        {
            panelMenuRight.Location = new Point(912, 52);
            panelMenuRight.Size = new Size(385, 468);
            panelCart.Location = new Point(2, 2);
            panelCart.Size = new Size(385, 466);

            panelCategory.Location = new Point(10, 3);
            panelCategory.Size = new Size(895, 43);

            panelSearch.Location = new Point(920, 8);
            panelSearch.Size = new Size(210, 31);
            txtSearchItemInCart.Location = new Point(7, 7);
            txtSearchItemInCart.Size = new Size(200, 14);
            txtSearchItemInCart.SubmitOnEnter = true;
            txtSearchItemInCart.TextSubmitted += TxtSearchItemInCart_Enter;
            txtSearchItemInCart.TextChanged += TxtSearchItemInCart_TextChanged;

            panelNavigation.Location = new Point(11, 52);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(890, 85);
            panelNavigation.TabIndex = 16;

            //--dungeonComboBox1.Location = new Point(0, 0);
            //--comboBrand.Size = new Size(220, 26);
            comboBrand.Size = new Size(250, 28);
            comboBrand.Enabled = true;
            comboBrand.SelectedValueChanged += ComboBrand_SelectedValueChanged;
            //-- comboBrand.Enter += panelHoverSelectBrand_Paint;

            //--pnlPager.Location = new Point(625, 42);
            pnlPager.Size = new Size(253, 31);

            //--panelHoverSelectBrand.Location = new Point(625, 9);
           // panelHoverSelectBrand.Size = new Size(230, 26);
            //--panelHoverSelectBrand.Controls.Add(comboBrand);

           /*-- panelHoverDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelHoverDropDown.Location = new Point(760, 11);
            panelHoverDropDown.Name = "panelHoverDropDown";
            panelHoverDropDown.Size = new Size(259, 32);
            panelHoverDropDown.TabIndex = 0;*/
        }

        private void ComboBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBrand.SelectedIndex > 0)
            {
                var brandCode = (BrandResponse)comboBrand.SelectedItem;
                //var products = Products.Where(e => e.BrandCode == brandCode.Code).ToList();
                var products = Products.Where(e => e.Brand == brandCode.Name).ToList();
                InitListProduct(PageIndex, products);
                /*var divisions = Divisions.Where(e => products.Any(p => p.Division_Id == e.Id)).ToList();
                InitListDivisions(divisions);*/
            }
            else if(comboBrand.SelectedIndex == 0)
            {
                InitListProduct(PageIndex, Products);
                /*InitListDivisions(Divisions);*/
            }
        }

        private void TxtSearchItemInCart_Enter(object sender, string e)
        {
            //SimulateScanData();
            txtSearchItemInCart.AppendText(e + "\r\n\r\n");
        }

        private System.Windows.Forms.Timer scanningTimer = new System.Windows.Forms.Timer();
        private StringBuilder scannedDataBuffer = new StringBuilder();
        /// </summary>
        //
       
        private void ProductInCart_Selected(object? sender, EventArgs e)
        {
            Control selectedProductControl = null;

            if (sender is Panel || sender is PictureBox)
            {
                // Determine the selected product control
                selectedProductControl = sender as Control;
                if (selectedProductControl == null && sender is PictureBox)
                {
                    selectedProductControl = ((PictureBox)sender).Parent as Control;
                }
                // Iterate through the controls in panelCart
                foreach (Control control in panelCart.Controls)
                {
                    if (control is UC_ProuductForCart productCart)
                    {
                        // Check if the current product control matches the selected control
                        if (productCart.panelCard == selectedProductControl || productCart.picProduct == selectedProductControl)
                        {
                            //_productDiscount.Clear();
                            ProductApplyDiscount = productCart.GetProduct.Product_Id;
                            var productIsDiscount = Products.FirstOrDefault(e => e.Id == ProductApplyDiscount);

                            if (productIsDiscount.Id == ProductApplyDiscount && productIsDiscount.DiscountAmount > 0 || productIsDiscount.DiscountPercent > 0)
                            {
                                ProductApplyDiscount = "";
                                MessageBox.Show("Product already apply discount", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            productCart.BorderStyle = BorderStyle.FixedSingle;
                        }
                        else
                        {
                            productCart.BorderStyle = BorderStyle.None;
                        }
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            lbNewItem = new Label();
            UC_FooterTotal = new UC_FooterTotal(this);
            panelCategory = new FlowLayoutPanel();
            panelSearch = new ReaLTaiizor.Controls.MaterialCard();
            txtSearchItemInCart = new ScanInputBox();
            panelHeader = new Panel();
            pictureBoxHoldCart = new PictureBox();
            btnHoldCart = new NotificationButton();
            panelHeaderHover = new Panel();
            btnHome = new ReaLTaiizor.Controls.ForeverButton();
            btnItem = new ReaLTaiizor.Controls.ForeverButton();
            panelListproduct = new FlowLayoutPanel();
            comboBrand = new ReaLTaiizor.Controls.DungeonComboBox();
            panelCart = new FlowLayoutPanel();
            panelMenuRight = new ReaLTaiizor.Controls.MaterialCard();
            panelFooterHover = new FlowLayoutPanel();
            panelNavigation = new Panel();
            pnlPager = new Panel();
            panelSearch.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHoldCart).BeginInit();
            panelMenuRight.SuspendLayout();
            panelFooterHover.SuspendLayout();
            panelNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // lbNewItem
            // 
            lbNewItem.BackColor = Color.YellowGreen;
            lbNewItem.Cursor = Cursors.Hand;
            lbNewItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lbNewItem.ForeColor = Color.White;
            lbNewItem.Location = new Point(74, 28);
            lbNewItem.MaximumSize = new Size(140, 15);
            lbNewItem.MinimumSize = new Size(100, 15);
            lbNewItem.Name = "lbNewItem";
            lbNewItem.Size = new Size(100, 15);
            lbNewItem.TabIndex = 34;
            lbNewItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_FooterTotal
            // 
            UC_FooterTotal.Location = new Point(3, 3);
            UC_FooterTotal.Name = "UC_FooterTotal";
            UC_FooterTotal.Size = new Size(384, 139);
            UC_FooterTotal.TabIndex = 0;
            // 
            // panelCategory
            // 
            panelCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCategory.Cursor = Cursors.Hand;
            panelCategory.Location = new Point(10, 3);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(65535, 0);
            panelCategory.TabIndex = 4;
            panelCategory.WrapContents = false;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelSearch.BackColor = Color.FromArgb(255, 255, 255);
            panelSearch.Controls.Add(txtSearchItemInCart);
            panelSearch.Depth = 0;
            panelSearch.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelSearch.Location = new Point(32736, 11);
            panelSearch.Margin = new Padding(14);
            panelSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(14);
            panelSearch.Size = new Size(159, 0);
            panelSearch.TabIndex = 3;
            // 
            // txtSearchItemInCart
            // 
            txtSearchItemInCart.BorderStyle = BorderStyle.None;
            txtSearchItemInCart.Font = new Font("Times New Roman", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchItemInCart.ForeColor = Color.Black;
            txtSearchItemInCart.Location = new Point(0, 9);
            txtSearchItemInCart.Name = "txtSearchItemInCart";
            txtSearchItemInCart.PlaceholderText = "     Scan or Input barcode";
            txtSearchItemInCart.Size = new Size(148, 16);
            txtSearchItemInCart.SubmitOnEnter = true;
            txtSearchItemInCart.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(16, 107, 67);
            panelHeader.Controls.Add(pictureBoxHoldCart);
            panelHeader.Controls.Add(btnHoldCart);
            panelHeader.Controls.Add(panelSearch);
            panelHeader.Controls.Add(panelCategory);
            panelHeader.Controls.Add(panelHeaderHover);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 50);
            panelHeader.TabIndex = 2;
            // 
            // pictureBoxHoldCart
            // 
            pictureBoxHoldCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxHoldCart.BackColor = Color.FromArgb(215, 234, 213);
            pictureBoxHoldCart.BackgroundImage = Properties.Resources.CartHold;
            pictureBoxHoldCart.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxHoldCart.Cursor = Cursors.Hand;
            pictureBoxHoldCart.Location = new Point(1217, 10);
            pictureBoxHoldCart.Name = "pictureBoxHoldCart";
            pictureBoxHoldCart.Size = new Size(27, 28);
            pictureBoxHoldCart.TabIndex = 31;
            pictureBoxHoldCart.TabStop = false;
            pictureBoxHoldCart.Click += pictureBoxHoldCart_Click;
            // 
            // btnHoldCart
            // 
            btnHoldCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnHoldCart.BackgroundImage = Properties.Resources.CartHold;
            btnHoldCart.BackgroundImageLayout = ImageLayout.Stretch;
            btnHoldCart.BorderColor = Color.FromArgb(220, 223, 230);
            btnHoldCart.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnHoldCart.DangerColor = Color.FromArgb(245, 108, 108);
            btnHoldCart.DefaultColor = Color.FromArgb(255, 255, 255);
            btnHoldCart.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoldCart.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnHoldCart.InfoColor = Color.FromArgb(144, 147, 153);
            btnHoldCart.Location = new Point(1207, 9);
            btnHoldCart.Name = "btnHoldCart";
            btnHoldCart.NotificationCount = 0;
            btnHoldCart.PrimaryColor = Color.FromArgb(215, 234, 213);
            btnHoldCart.Size = new Size(52, 30);
            btnHoldCart.SuccessColor = Color.FromArgb(103, 194, 58);
            btnHoldCart.TabIndex = 7;
            btnHoldCart.TextColor = Color.White;
            btnHoldCart.WarningColor = Color.FromArgb(230, 162, 60);
            btnHoldCart.Click += btnShowCart_Click;
            // 
            // panelHeaderHover
            // 
            panelHeaderHover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHeaderHover.Cursor = Cursors.Hand;
            panelHeaderHover.Location = new Point(4, 5);
            panelHeaderHover.Name = "panelHeaderHover";
            panelHeaderHover.Padding = new Padding(0, 2, 0, 0);
            panelHeaderHover.Size = new Size(65535, 0);
            panelHeaderHover.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BaseColor = Color.YellowGreen;
            btnHome.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.Black;
            btnHome.Location = new Point(15, 73);
            btnHome.Name = "btnHome";
            btnHome.Rounded = false;
            btnHome.Size = new Size(57, 31);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.TextColor = Color.FromArgb(243, 243, 243);
            btnHome.Click += btnHome_Click;
            // 
            // btnItem
            // 
            btnItem.BackColor = Color.YellowGreen;
            btnItem.BaseColor = Color.YellowGreen;
            btnItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItem.Location = new Point(70, 21);
            btnItem.MaximumSize = new Size(150, 31);
            btnItem.MinimumSize = new Size(100, 31);
            btnItem.Name = "btnItem";
            btnItem.Rounded = false;
            btnItem.Size = new Size(110, 31);
            btnItem.TabIndex = 3;
            btnItem.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // panelListproduct
            // 
            panelListproduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListproduct.Cursor = Cursors.Hand;
            panelListproduct.Location = new Point(0, 142);
            panelListproduct.Margin = new Padding(0);
            panelListproduct.Name = "panelListproduct";
            panelListproduct.Padding = new Padding(6, 10, 0, 0);
            panelListproduct.Size = new Size(905, 630);
            panelListproduct.TabIndex = 4;
            // 
            // comboBrand
            // 
            comboBrand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBrand.BackColor = Color.White;
            comboBrand.ColorA = Color.FromArgb(16, 107, 67);
            comboBrand.ColorB = Color.FromArgb(16, 107, 67);
            comboBrand.ColorC = Color.FromArgb(242, 241, 240);
            comboBrand.ColorD = Color.FromArgb(253, 252, 252);
            comboBrand.ColorE = Color.FromArgb(239, 237, 236);
            comboBrand.ColorF = Color.FromArgb(180, 180, 180);
            comboBrand.ColorG = Color.FromArgb(119, 119, 118);
            comboBrand.ColorH = Color.FromArgb(224, 222, 220);
            comboBrand.ColorI = Color.FromArgb(250, 249, 249);
            comboBrand.DrawMode = DrawMode.OwnerDrawFixed;
            comboBrand.DropDownHeight = 300;
            comboBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBrand.Font = new Font("Segoe UI", 10F);
            comboBrand.ForeColor = Color.DarkGray;
            comboBrand.HoverSelectionColor = Color.Empty;
            comboBrand.IntegralHeight = false;
            comboBrand.ItemHeight = 25;
            comboBrand.Location = new Point(625, 9);
            comboBrand.Name = "comboBrand";
            comboBrand.Size = new Size(250, 31);
            comboBrand.StartIndex = 0;
            comboBrand.TabIndex = 0;
            // 
            // panelCart
            // 
            panelCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCart.AutoScroll = true;
            panelCart.Cursor = Cursors.Hand;
            panelCart.Location = new Point(2, 2);
            panelCart.Name = "panelCart";
            panelCart.Padding = new Padding(0, 2, 0, 0);
            panelCart.Size = new Size(386, 468);
            panelCart.TabIndex = 1;
            // 
            // panelMenuRight
            // 
            panelMenuRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelMenuRight.BackColor = Color.FromArgb(255, 255, 255);
            panelMenuRight.Controls.Add(panelCart);
            panelMenuRight.Depth = 0;
            panelMenuRight.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelMenuRight.Location = new Point(911, 52);
            panelMenuRight.Margin = new Padding(14);
            panelMenuRight.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            panelMenuRight.Name = "panelMenuRight";
            panelMenuRight.Padding = new Padding(14);
            panelMenuRight.Size = new Size(386, 468);
            panelMenuRight.TabIndex = 15;
            // 
            // panelFooterHover
            // 
            panelFooterHover.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelFooterHover.Controls.Add(UC_FooterTotal);
            panelFooterHover.Cursor = Cursors.Hand;
            panelFooterHover.Location = new Point(908, 522);
            panelFooterHover.Name = "panelFooterHover";
            panelFooterHover.Size = new Size(393, 260);
            panelFooterHover.TabIndex = 2;
            // 
            // panelNavigation
            // 
            panelNavigation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNavigation.Controls.Add(comboBrand);
            panelNavigation.Controls.Add(lbNewItem);
            panelNavigation.Controls.Add(pnlPager);
            panelNavigation.Controls.Add(btnItem);
            panelNavigation.Location = new Point(10, 52);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(895, 88);
            panelNavigation.TabIndex = 16;
            // 
            // pnlPager
            // 
            pnlPager.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPager.Location = new Point(625, 55);
            pnlPager.Name = "pnlPager";
            pnlPager.Size = new Size(250, 26);
            pnlPager.TabIndex = 32;
            // 
            // View_POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 213);
            ClientSize = new Size(1300, 785);
            Controls.Add(panelFooterHover);
            Controls.Add(panelMenuRight);
            Controls.Add(panelListproduct);
            Controls.Add(panelHeader);
            Controls.Add(btnHome);
            Controls.Add(panelNavigation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_POS";
            Text = "View_POS";
            TransparencyKey = Color.Fuchsia;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHoldCart).EndInit();
            panelMenuRight.ResumeLayout(false);
            panelFooterHover.ResumeLayout(false);
            panelNavigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        /*private void ViewPOS_LoadingData(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private FlowLayoutPanel panelCategory;
        private ReaLTaiizor.Controls.MaterialCard panelSearch;
        private ScanInputBox txtSearchItemInCart;
        private Panel panelHeader;
        private ReaLTaiizor.Controls.ForeverButton btnHome;
        private ReaLTaiizor.Controls.ForeverButton btnItem;
        private FlowLayoutPanel panelListproduct;
        private UserControls.UC_ProuductCard uC_ProuductCard1;
        private UserControls.UC_ProuductForCart uC_ProuductForCard1;
        private UserControls.UC_ProuductForCart uC_ProuductForCard2;
        private UserControls.UC_ProuductForCart uC_ProuductForCard3;
        private FlowLayoutPanel panelCart;
        private ReaLTaiizor.Controls.MaterialCard panelMenuRight;
        private Panel panelNavigation;
        private ReaLTaiizor.Controls.DungeonComboBox comboBrand;
        //--private Panel panelHoverDropDown;
        private Panel pnlPager;
        private Panel panelHeaderHover;
        private FlowLayoutPanel panelFooterHover;
        private Label lbNewItem;
        public UC_FooterTotal UC_FooterTotal;
        private UC_AllButton UC_AllButton;
        private CustomTouchScroll productTouchScroll;
        private CustomTouchScroll _scrollPanelCart;
        public CustomStyles.NotificationButton btnHoldCart;
        private PictureBox pictureBoxHoldCart;
    }
}