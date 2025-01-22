using CashierPOS.Model.Models.PaymentType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.Services
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IRepository<PaymentType> _repo;
        private readonly IRepository<Order> _repoOrder;

        public PaymentTypeService(IRepository<PaymentType> repo, IRepository<Order> repoOrder)
        {
            _repo = repo;
            _repoOrder = repoOrder;
        }

        public Response<List<PaymentTypeResponse>> ReadAll()
        {
            try
            {
                var data = _repo.GetAll().Select(e => new PaymentTypeResponse()
                {
                    Code = e.PaymentCode,
                    Name = e.Name,
                }).OrderBy(e=> e.Code).ToList();

                return Response<List<PaymentTypeResponse>>.Success(data,data.Count, "Successfully");
            }
            catch (Exception ex)
            {
                return Response<List<PaymentTypeResponse>>.Fail(ex.Message);
            }
        }

    }

    public interface IPaymentTypeService
    {
        public Response<List<PaymentTypeResponse>> ReadAll();
    }
}
