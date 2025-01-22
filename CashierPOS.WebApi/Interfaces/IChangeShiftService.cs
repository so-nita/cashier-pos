using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.WebApi.Models.RequestModel.ChangeShift;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.ChangeShift;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IChangeShiftService : IService<ChangeShiftResponse, ChangeShiftCreateReq, ChangeShiftUpdateReq, Key>
    {
        Response<OpenShiftResponse> OpenShift(ChangeShiftCreateReq request);
        Response<string> CloseShift(ChangeShiftCloseReq request);
        Response<CloseShiftSummaryRqsponse> PrintSummaryShift(CloseShiftPrintSummaryReq request);
    }

    
}
