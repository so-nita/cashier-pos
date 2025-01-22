using CashierPOS.Model.Models.Division;
using CashierPOS.Model.Models.Response;
using Microsoft.AspNetCore.Http;

namespace CashierPOS.UI.Service
{
    public class DivisionService : BaseService
    {
        private string _getUrl => BaseUrl + _endPoint;
        private string _endPoint { get; set; } = "division";
        public async Task<List<DivisionResponse>> GetAllAsync()
        {
            try
            {
                var data = await GetAsync<Response<List<DivisionResponse>>>(_getUrl);
                return data.Result!;
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public async Task<List<DivisionResponse>> GetAllByProductAsync()
        {
            try
            {
                _endPoint += "/getByProduct";
                var data = await GetAsync<Response<List<DivisionResponse>>>(_getUrl);
                return data.Result!;
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
    }
}
