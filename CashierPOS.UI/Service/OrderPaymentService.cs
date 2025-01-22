using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.UI.Service
{
    public class OrderPaymentService : BaseService
    {
        private string _endPoint = "orderPayment";
        public string GetUrl => BaseUrl + _endPoint;
        public async Task<SellInvoiceResponse> CreatePaymentAsync(OrderPaymentCreateReq dataInOrder)
        {
            _endPoint += "/payWithPrintInvoice";
            var data = await PostAsync<OrderPaymentCreateReq, Response<SellInvoiceResponse>>(GetUrl, dataInOrder);
            if (data?.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return default!;
        }

        public async Task<Response<SellInvoiceResponse>> CreateReturnPaymentAsync(OrderPaymentReturnReq dataInOrder)
        {
            _endPoint += "/paymentForReturn";
            var data = await PostAsync<OrderPaymentReturnReq, Response<SellInvoiceResponse>>(GetUrl, dataInOrder);
            /*if (data.Status == (int)ResponseStatus.Success)
            {
                return data.!;
            }*/
            return data!;
        }

        public async Task<List<PaymentMethodResponse>> GetPaymentMethods()
        {
            _endPoint = "paymentMethod";
            var data = await GetAsync<Response<List<PaymentMethodResponse>>>(GetUrl);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return null!;
            }
            return data.Result!;
        }
    }
}