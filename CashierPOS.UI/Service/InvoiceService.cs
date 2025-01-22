using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Service
{
    public class InvoiceService : BaseService
    {
        private string _getUrl => BaseUrl + _endPoint;
        private string _endPoint { get; set; } = "sellInvoice";
        public async Task<SellInvoiceResponse> GetAsync(string invoiceNo)
        {
            _endPoint += $"/{invoiceNo}";
            var data = await GetAsync<Response<SellInvoiceResponse>>(_getUrl);
            if(data.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return default!;
        }

        public async Task<Response<SellInvoiceResponse>> CreateInvoiceByLast(ReprintInvoiceByLast request)
        {
            _endPoint += "/reprintByLast";
            var data = await PostAsync<ReprintInvoiceByLast, Response<SellInvoiceResponse>>(_getUrl, request);
            return data.Status == (int)ResponseStatus.Success ? data : default!;
        }
        public async Task<Response<SellInvoiceResponse>> CreateInvoiceByInvoiceNo(ReprintInvoiceByNo request)
        {
            _endPoint += "/reprintByNo";
            var data = await PostAsync<ReprintInvoiceByNo, Response<SellInvoiceResponse>>(_getUrl, request);
            return data.Status == (int)ResponseStatus.Success ? data : default!;
        }
    }
}
