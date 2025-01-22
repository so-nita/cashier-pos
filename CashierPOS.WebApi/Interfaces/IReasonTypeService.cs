using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.WebApi.Interfaces
{
    public interface IReasonTypeService
    {
        public Response<List<ReasonTypeResponse>> ReadAll();
    }
}
