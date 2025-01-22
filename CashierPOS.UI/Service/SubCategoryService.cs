using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Category;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.UI.Service
{
    public class SubCategoryService : BaseService
    {
        private string EndPoint { get; set; } = "subcategory";
        private string GetUrl => BaseUrl + EndPoint;
        // For get all category 
        public async Task<List<CategoryResponse>> GetAllAsync()
        {
            try
            {
                var data = await GetAsync<Response<List<CategoryResponse>>>(GetUrl);
                return data.Result!;
            }
            catch
            {
                return default!;
            }
        }

        // For create all category 
        public async Task<Response<string>> CreateAsync(CategoryCreateReq request)
        {
            try
            {
                var data = await PostAsync<CategoryCreateReq, Response<string>>(GetUrl, request);
                return data!;
            }
            catch
            {
                return default!;
            }
        }
        // For update all category 
        public async Task<Response<string>> UpdateAsync(CategoryUpdateReq request)
        {
            try
            {
                var data = await PutAsync<CategoryUpdateReq, Response<string>>(GetUrl, request);
                return data!;
            }
            catch
            {
                return default!;
            }
        }
        // For delete all category 
        public async Task<Response<string>> DeleteAsync(Key request)
        {
            try
            {
                var data = await DeleteAsync<Key>(GetUrl, request);
                return data!;
            }
            catch
            {
                return default!;
            }
        }
    }
}
