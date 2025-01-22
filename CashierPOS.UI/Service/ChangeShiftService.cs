using CashierPOS.Model.Models.ChangeShift;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Models.RequestModel.ChangeShift;

namespace CashierPOS.UI.Service
{
    public class ChangeShiftService : BaseService
    {
        private string GetUrl => BaseUrl + EndPoint;
        private string EndPoint { get; set; } = "changeshift";
        public async Task<Response<OpenShiftResponse>> OpenChangeShift(ChangeShiftCreateReq request)
        {
            EndPoint += "/open";
            var data = await PostAsync<ChangeShiftCreateReq, Response<OpenShiftResponse>>(GetUrl, request);

            if (data == null)
            {
                return null!;
            }
            if (data.Status == (int)ResponseStatus.Success)
            {
                return data;
            }
            return null!;
        }

        //Close Shift 
        public async Task<string> CloseShift(ChangeShiftCloseReq request)
        {
            EndPoint += "/close";
            var data = await PutAsync<ChangeShiftCloseReq, Response<string>>(GetUrl, request);

            if (data == null)
            {
                return null!;
            }
            if (data.Status == (int)ResponseStatus.Success)
            {
                return data.Result!;
            }
            return null!;
        }

        public async Task<Response<CloseShiftSummaryRqsponse>> CreateReceiptSummaryCloseShift(string request)
        {
            EndPoint += $"/{request}";
            var data = await GetAsync<Response<CloseShiftSummaryRqsponse>>(GetUrl);
            return data;
        }

    }
}
