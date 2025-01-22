using CashierPOS.Model.Models.Category;
using CashierPOS.Model.Models.Product;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Service
{
    public class CategoryService : BaseService
    {
        private string _getUrl => BaseUrl + _endPoint;
        private string _endPoint { get; set; }= "category";
        public async Task<List<CategoryResponse>> GetAllAsync()
        {
            try
            {
                var data = await GetAsync<Response<List<CategoryResponse>>>(_getUrl);
                return data.Result!;
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        
    }
}
