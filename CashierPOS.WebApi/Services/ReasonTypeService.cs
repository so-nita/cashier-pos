using CashierPOS.Model.Constants;
using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.Services
{
    public class ReasonTypeService : IReasonTypeService
    {
        private readonly IRepository<ReasonType> _repo;

        public ReasonTypeService(IRepository<ReasonType> repo)
        {
            _repo = repo;
        }

        public Response<List<ReasonTypeResponse>> ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Where(e => e.Reason_Type == ReasonCancel.Cancel.ToString().ToLower())
                    .Select(e=> new ReasonTypeResponse()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Type = e.Reason_Type
                    }).ToList();
                return Response<List<ReasonTypeResponse>>.Success(data,data.Count(),"Successfully");
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
    }

    

    
}
