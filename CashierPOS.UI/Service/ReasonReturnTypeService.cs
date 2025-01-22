using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.UI.Service
{
    public class ReasonReturnTypeService : BaseService
    {
        private string _endPoint = "reasonReturnType";
        public string GetUrl => BaseUrl + _endPoint;

        public async Task<List<ReasonReturnTypeResponse>> GetAllAsync()
        {
            var data = await GetAsync<Response<List<ReasonReturnTypeResponse>>>(GetUrl);
            if (data.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return default!;
        }
    }
}
