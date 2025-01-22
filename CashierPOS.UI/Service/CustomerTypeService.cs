using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.CustomerType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Service
{
    public class CustomerTypeService : BaseService
    {
        private string _endPoint = "customerType";
        public string GetUrl => BaseUrl + _endPoint;

        public async Task<List<CustomerTypeResponse>> GetAllAsync()
        {
            var data = await GetAsync<Response<List<CustomerTypeResponse>>>(GetUrl);
            if (data.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return default!;
        }

        public async Task<SellInvoiceResponse> CreatePaymentAsync(OrderPaymentCreateReq dataInOrder)
        {
            var data = await PostAsync<OrderPaymentCreateReq, Response<SellInvoiceResponse>>(GetUrl, dataInOrder);
            if (data.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return default!;
        }
    }
}
