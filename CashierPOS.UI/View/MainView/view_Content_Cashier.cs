using CashierPOS.Model.Models.Category;
using CashierPOS.Model.Models.Division;
using CashierPOS.UI.Components;
using CashierPOS.UI.Constant;
using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.UserControls;
using CashierPOS.UI.View_PopUp;
using ReaLTaiizor.Controls;

namespace CashierPOS.UI.View_Content_Cashier;

public partial class view_Content_Cashier : Form, IMainView
{
    private IMainView _mainView;

    Action<string> IMainView.SearchItem { get; set; }

    public view_Content_Cashier(IMainView mainView)
    {
        InitializeComponent();
        InitializeCategoryButton();
        _mainView = mainView;
        UC_AllButton = new UC_AllButton(_mainView, null!);
        _scrollCategory = new CustomTouchScroll(panelCategory, ScrollDirection.Horizontal);
        InitbuttonAllCategory();
    }

    public event EventHandler<string> SearchItem;
    public void AddController(Form form) { }

    public void CloseView()
    {
        this.Close();
        PopUp_Background.ClosePopUp();
    }

    //-- public bool IsLogout { get; set; } = false;
    public void SetIsLogout(bool value) => UC_AllButton.IsUserLoggedOut = value;
    public bool IsLogout => UC_AllButton.IsUserLoggedOut;
    public void LoadData()
    {
        UC_AllButton.SetIsLogin(false);
        UC_AllButton.IsOpenShift = false;
        UC_AllButton.ChangeButton();
    }
    private async void InitializeCategoryButton()
    {
        /*var service = new CategoryService();
        var categories = await service.GetAllAsync();
        foreach (var item in categories)
        {
            CreateButtonCategory(item);
        }*/
        var service = new DivisionService();
        var categories = await service.GetAllByProductAsync();
        foreach (var item in categories)
        {
            CreateButtonCategory(item);
        }
    }


    private void InitbuttonAllCategory()
    {
        var btnAllCategory = new LostButton();
        btnAllCategory.BackColor = Color.FromArgb(16, 107, 67);
        btnAllCategory.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        btnAllCategory.ForeColor = Color.White;
        btnAllCategory.HoverColor = Color.FromArgb(56, 56, 56);
        btnAllCategory.Size = new Size(140, 40);
        btnAllCategory.Text = "All Category";
        panelCategory.Controls.Add(btnAllCategory);
    }

    private void CreateButtonCategory(/*CategoryResponse*/DivisionResponse item)
    {
        var btnCategory = new LostButton
        {
            BackColor = Color.FromArgb(16, 107, 67),
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point),
            ForeColor = Color.White,
            HoverColor = Color.FromArgb(56, 56, 56),
            Image = null,
            Location = new Point(403, 194),
            Size = new Size(140, 40),
            TabIndex = 3,
            Text = item.Name,
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom,
        };
        panelCategory.Controls.Add(btnCategory);
        _scrollCategory.AssignScrollEvent(btnCategory);
    }

    public void View_Content_Cashier_Load(object sender, EventArgs e)
    {
        panelContainUC_Footer.Controls.Add(UC_AllButton);
        InitializeComponentData();
    }
 
}

