using CashierPOS.Model.Interface;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;


namespace CashierPOS.WebApi.Interfaces
{
    public interface IOrderPaymentService : IService<OrderPaymentResponse, OrderPaymentCreateReq, OrderPaymentUpdateReq, Key>
    {
        public Response<SellInvoiceResponse> CreatePaymentWithInvoice(OrderPaymentCreateReq req);
        public Response<SellInvoiceResponse> CreatePaymentForReturn(OrderPaymentReturnReq request);
    }
 
}
