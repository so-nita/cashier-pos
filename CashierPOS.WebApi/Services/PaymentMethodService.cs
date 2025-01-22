using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.PaymentMethod;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.Services
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IRepository<PaymentMethod> _repo;

        public PaymentMethodService(IRepository<PaymentMethod> repo)
        {
            _repo = repo;
        }

        public Response<List<PaymentMethodResponse>>? ReadAll()
        {
            try
            {
                var data = _repo.GetAll().OrderBy(e => e.Create_At).Select(e => new PaymentMethodResponse
                {
                    Id = e.Id,
                    //Code = e.Code,
                    Name = e.Name,
                    Currency = e.Currency,
                    Logo = e.Logo,
                }).OrderBy(e=>e.Name).ToList();
                return Response<List<PaymentMethodResponse>>.Success(data, data.Count(),"Successfully");
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<PaymentMethodResponse>>? ReadPaymentForPay()
        {
            try
            {
                var data = _repo.GetAll()
                    .Where(e=> !e.Name.StartsWith("CASH"))
                    .Select(e => new PaymentMethodResponse
                    {
                        Id = e.Id,
                        //--Code = e.Code,
                        Name = e.Name,
                        Currency = e.Currency,
                        Logo = e.Logo,
                    }).OrderBy(e => e.Name).ToList();

                return Response<List<PaymentMethodResponse>>.Success(data, data.Count(), "Successfully");
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Create(PaymentMethodCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Response<string> Delete(Key key)
        {
            throw new NotImplementedException();
        }

        public Response<PaymentMethodResponse?> Read(Key key)
        {
            throw new NotImplementedException();
        }


        public Response<string> Update(PaymentMethodUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPaymentMethodService : IService<PaymentMethodResponse,PaymentMethodCreateReq,PaymentMethodUpdateReq,Key>
    {
        public Response<List<PaymentMethodResponse>>? ReadPaymentForPay();
    }
}
