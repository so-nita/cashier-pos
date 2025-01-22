using CashierPOS.Model;
using CashierPOS.Model.Models.Category;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.UI.Service;
using CashierPOS.UI.View_PopUp;
using CashierPOS.WebApi.Interface.Product;
using Microsoft.AspNetCore.Http;

namespace CashierPOS.UI.View.View_PopUp
{
    public partial class PopUp_CreateItem : Form
    {
        public PopUp_CreateItem()
        {
            InitializeComponent();
            InitializeComponentData();
            InitializeData();
        }

        private void InitializeData()
        {
            ItemInCategory();
        }
        private List<CategoryResponse> Categories { get; set; } 
        private async void ItemInCategory()
        {
            var service = new SubCategoryService();
            Categories = await service.GetAllAsync();
            comboCategory.Items.Add("-- Select --");
            comboCategory.SelectedIndex = 0;
            foreach (var item in Categories)
            {
                comboCategory.Items.Add(item.Name);
                comboCategory.ValueMember = item.Id;
            }
            comboCategory.Enter += ComboCategory_SelectedIndexChanged;
        }

        private void ComboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            comboCategory.Items.Remove("-- Select --");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var categoryId = "";
                if (comboCategory.SelectedItem != null)
                {
                    categoryId = Categories.FirstOrDefault(e => e.Id == comboCategory.ValueMember)!.Id;
                }

                var newItemReq = new ProductCreateReq()
                {
                    Name = "TT-001", //txtName.Text,
                    NameKh = "TT-001",//txtNameKh.Text.Trim() ?? null,
                    Cost = 3,//CustomStyle.ConvertStringToDecimal(txtCost.Text, "$"),
                    Price = 4,// CustomStyle.ConvertStringToDecimal(txtPrice.Text, "$"),
                    Category_Id = "6C6B806B-9C75-4BDC-BC7D-9AB33C210D27", //categoryId!,
                    Create_By = "E2A834A5-585C-48B2-A3C2-1C13AAC250E4",/*AppStoreContext.CurrentUser.UserId,*/
                    Description = txtDescription.Text,
                    // Upload image 
                    Image = openFile.FileName,
                };

                var service = new ProductService();
                var dataResponse = await service.CreateAsync(newItemReq);
                if (dataResponse?.Status == (int)ResponseStatus.Success)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private OpenFileDialog openFile;
        private async Task<string> UploadImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var ms = new MemoryStream();
                var formFile = new FormFile(ms, 0, ms.Length, "Image", openFile.FileName)
                {
                    Headers = new HeaderDictionary(),
                    ContentType = "image/jpeg",  
                    ContentDisposition = $"form-data; name=\"Image\"; filename=\"{openFile.FileName}\"",
                };

                var service = new UploadImageService();
                var requestModel = new ImageModel()
                {
                    Image = formFile,
                    Name = openFile.FileName,
                };
                var response = await service.Upload(requestModel);

                if (response?.Status == (int)ResponseStatus.Success)
                {
                    return response.Result!;
                }
                else
                {
                    MessageBox.Show("Image upload failed.");
                }
            }
            return null!;
        }

        // test
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            _ = UploadImage();
        }
    }

    public class UploadImageService : BaseService
    {
        private string _endPoiny = "uploadImage";
        private string _getEndPoint => BaseUrl + _endPoiny;

        public async Task<Response<string>> Upload(ImageModel image)
        {
            var response = await PostAsync<ImageModel, Response<string>>(_getEndPoint, image);
            if(response.Status != (int)ResponseStatus.Success)
            {
                return response;
            }
            return null!;
        }
    }
}
