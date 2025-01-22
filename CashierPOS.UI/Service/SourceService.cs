using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.CustomerType;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.Source;

namespace CashierPOS.UI.Service
{
    public class SourceService : BaseService
    {
        private string _endPoint = "source";
        public string GetUrl => BaseUrl + _endPoint;

        public async Task<List<SourceResponse>> GetAllAsync()
        {
            var data = await GetAsync<Response<List<SourceResponse>>>(GetUrl);
            if (data.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return default!;
        }
    }
}
