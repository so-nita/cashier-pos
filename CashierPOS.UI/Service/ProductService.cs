using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Product;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface.Product;

namespace CashierPOS.UI.Service
{
    public class ProductService : BaseService
    {
        private string EndPoint { get; set; } = "product";
        private string GetUrl => BaseUrl + EndPoint;
        // For get all products 
        public async Task<List<ProductResponse>> GetAllAsync()
        {
            try
            {
                //EndPoint = "product/getForSell";
                var data = await GetAsync<Response<List<ProductResponse>>>(GetUrl);
                return data.Result!;
            }
            catch
            {
                return default!;
            }
        }

        // For create all products 
        public async Task<Response<string>> CreateAsync(ProductCreateReq request)
        {
            try
            {
                var data = await PostAsync<ProductCreateReq, Response<string>>(GetUrl, request);
                return data!;
            }
            catch
            {
                return default!;
            }
        }
        // For update all products 
        public async Task<Response<string>> UpdateAsync(ProductUpdateReq request)
        {
            try
            {
                var data = await PutAsync<ProductUpdateReq, Response<string>>(GetUrl, request);
                return data!;
            }
            catch
            {
                return default!;
            }
        }
        // For delete all products 
        public async Task<Response<string>> DeleteAsync(Key request)
        {
            try
            {
                var data = await DeleteAsync<Key>(GetUrl,request);
                return data!;
            }
            catch
            {
                return default!;
            }
        }
    }
}
