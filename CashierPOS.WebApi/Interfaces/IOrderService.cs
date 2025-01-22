using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Interface;
using CashierPOS.Model.Models.RequestModel.Order;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.WebApi.Interface;

public interface IOrderService : IService<OrderResponse, OrderCreateReq, OrderUpdateReq,OrderDeleteReq>
{
    public Response<OrderResponse> CreateOrder(OrderWithInvoiceCreateReq request);
    public Response<SellInvoiceResponse> CreateOrderWithInvoice(OrderCreateReq req);
    public Response<string> Delete(OrderDeleteReq request);
    public Response<string> Hold(Key orderId);
    public Response<string> Cancel(OrderCancelReq orderId);
    public Response<SellInvoiceResponse> Return(OrderReturnReq orderId);
    public Response<ReturnOrderResponse> GetReturnOrder(OrderReturnReq request);
    public Response<List<HoldOrderResponse>> GetHoldOrder(HoldOrderGetRequest request);
    public Response<SellInvoiceResponse> UpdateHoldToOrder(HoldOrderUpdateReq request);
}


 