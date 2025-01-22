using CashierPOS.Model.Models.Customer;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.UI.Service
{
    public class CustomerService : BaseService
    {
        private string _endPoint { get; set; } = "customer";
        private string _getUrl => BaseUrl + _endPoint;


        public async Task<List<CustomerResponse>> GetAll()
        {
            var data = await GetAsync<Response<List<CustomerResponse>>>(_getUrl);
            return data?.Result!;
        }

        public async Task<Response<string>> CreateAsync(CustomerCreateReq request)
        {
            var data = await PostAsync<CustomerCreateReq, Response<string>>(_getUrl ,request);

            return data;

        }


    }
}
