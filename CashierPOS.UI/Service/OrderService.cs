using CashierPOS.WebApi.Interface;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.RequestModel.Order;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;

namespace CashierPOS.UI.Service
{
    public class OrderService : BaseService
    {
        private string EndPoint = "order";
        private string GetUrl => BaseUrl + EndPoint;

        public async Task<Response<OrderResponse>> CreateOrderAsync(OrderWithInvoiceCreateReq request)
        {
            var data = await PostAsync<OrderWithInvoiceCreateReq, Response<OrderResponse>>(GetUrl, request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return default!;
            }
            return data;
        }

        // Adjust new order
        public async Task<Response<SellInvoiceResponse>> CreateOrderWithInoivceAsync(OrderCreateReq request)
        {
            EndPoint += "/createWithInvoice";
            var data = await PostAsync<OrderCreateReq, Response<SellInvoiceResponse>>(GetUrl, request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return default!;
            }
            return data;
        }


        public async Task<Response<ReturnOrderResponse>> GetReturnOrder(OrderReturnReq request)
        {
            EndPoint += "/getOrderReturn";
            var data = await PostAsync<OrderReturnReq, Response<ReturnOrderResponse>>(GetUrl, request);
            if (data?.Status == (int)ResponseStatus.Success)
            {
                return data;
            }
            return data!;
        }

        //Update Return Order
        public async Task<Response<SellInvoiceResponse>> ReturnOrderAsync(OrderReturnReq request)
        {
            EndPoint += "/return";
            var date = await PutAsync<OrderReturnReq, Response<SellInvoiceResponse>>(GetUrl, request);
            if (date.Status == (int)ResponseStatus.Success)
            {
                return date;
            }
            return default!;
        }

        public async Task<bool> DeleteOrderAsync(OrderDeleteReq request)
        {
            var data = await DeleteAsync<OrderDeleteReq>(GetUrl, request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> CancelOrderAsync(OrderCancelReq request)
        {
            EndPoint += "/cancel";
            var data = await PutAsync<OrderCancelReq, Response<string>>(GetUrl, request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return false;
            }
            return true;
        }

        public async Task<List<HoldOrderResponse>> GetAllHoldOrderAsync(HoldOrderGetRequest request)
        {
            EndPoint += "/getHoldOrder";
            var data = await PostAsync<HoldOrderGetRequest, Response<List<HoldOrderResponse>>>(GetUrl, request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return null!;
            }
            return data.Result!;
        }

        public async Task<Response<SellInvoiceResponse>> UpdateHoldOrder(HoldOrderUpdateReq request)
        {
            EndPoint += "/holdToOrder";
            
            var data = await PutAsync<HoldOrderUpdateReq, Response<SellInvoiceResponse>>(GetUrl, request);
            return data!;
        }


        /*
        public async Task<Response<OrderResponse>> GetOrderAsync(Key request)
        {
            EndPoint += "/getById";
            var data = await PostAsync<Key, Response<OrderResponse>>(GetUrl, request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return null!;
            }
            return data!;
        }*/
        /*public async Task<Response<string>> UpdateOrderAsync(OrderUpdateReq request)
        {
            var data = await PutAsync<OrderUpdateReq, Response<string>>(GetUrl, request);
            return data;
        }*/
    }
}