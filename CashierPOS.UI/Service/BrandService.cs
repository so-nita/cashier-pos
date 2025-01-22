using CashierPOS.Model.Models.Brand;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Service
{
    public class BrandService : BaseService
    {
        private string _endPoint { get; set; } = "brand";
        private string _getUrl => BaseUrl + _endPoint;

        public async Task<List<BrandResponse>> GetAllAsync()
        {
            var data = await GetAsync<Response<List<BrandResponse>>>(_getUrl);
            if (data?.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return null!;
        }
    }
}
