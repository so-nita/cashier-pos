using CashierPOS.Model.Interface;
using CashierPOS.WebApi.Models.RequestModel.SellInvoice;
using CashierPOS.Model.Models.Response;

namespace CashierPOS.WebApi.Interfaces
{
    public interface ISellInvoiceService : IService<SellInvoiceResponse, SellInvoiceCreateReq, SellInvoiceUpdateReq, SellInvoiceDisableReq>
    {
        public Response<SellInvoiceResponse> CreateAndPrint(SellInvoiceCreateReq req);
        public Task<Response<SellInvoiceResponse>> ReprintByLast(ReprintInvoiceByLast request);
        public Response<SellInvoiceResponse> ReprintByNo(ReprintInvoiceByNo request);
        public Response<SellInvoiceResponse> CreateSellInvoice(InvoiceCreateReq req);
    }
    public class SellInvoiceDisableReq : IDelete
    {
        public string InvoiceNo { get; set; } = "";
    }
}