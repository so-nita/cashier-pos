using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.UI.Service
{
    public class PaymentMethodService : BaseService
    {
        private string _getUrl => BaseUrl + _endPoint;
        private string _endPoint { get; set; } = "paymentMethod";

        public async Task<List<PaymentMethodResponse>> GetAllAsync()
        {
            var data = await GetAsync<Response<List<PaymentMethodResponse>>>(_getUrl);
            if (data?.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return null!;
        }

        public async Task<List<PaymentMethodResponse>> GetAllPaymentForPayAsync()
        {
            _endPoint += "/pay"; 
            var data = await GetAsync<Response<List<PaymentMethodResponse>>>(_getUrl);
            if (data?.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return null!;
        }
    }
}
