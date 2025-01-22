using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IReasonReturnTypeService
    {
        public Response<List<ReasonReturnTypeResponse>> ReadAll();
    }
}
