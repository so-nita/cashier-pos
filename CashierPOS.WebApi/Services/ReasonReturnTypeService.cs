using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.Services
{
    public class ReasonReturnTypeService : IReasonReturnTypeService
    {
        //private readonly IRepository<ReasonRefundType> _service;
        private readonly IRepository<ReasonType> _service;

        public ReasonReturnTypeService(IRepository<ReasonType> service)
        {
            _service = service;
        }

        public Response<List<ReasonReturnTypeResponse>> ReadAll()
        {
            try
            {
                var data = _service.GetAll().Where(e=>e.Reason_Type== ReasonCancel.Return.ToString().ToLower())
                    .Select(e => new ReasonReturnTypeResponse()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Type = e.Reason_Type
                    }).ToList();
                return Response<List<ReasonReturnTypeResponse>>.Success(data, data.Count(), "Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
    }
}
