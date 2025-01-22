using Microsoft.AspNetCore.Mvc;
using CashierPOS.WebApi.Interface;
using CashierPOS.Model.Models.Order;
using CashierPOS.Model.Models.RequestModel.Order;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        // Read Order
        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.ReadAll();
            if(data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Create Order
        [HttpPost]
        public IActionResult Post([FromBody] OrderWithInvoiceCreateReq request)
        {
            var data = _service.CreateOrder(request);
            if(data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Create Order
        [HttpPost("createWithInvoice")]
        public IActionResult CreateOrderWithInvoice([FromBody] OrderCreateReq request)
        {
            //var data = _service.Create(request);
            var data = _service.CreateOrderWithInvoice(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Create Order
        [HttpPost("getById")]
        public IActionResult Post([FromBody] Key request)
        {
            var data = _service.Read(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Update Order 
        [HttpPut]
        public IActionResult Put([FromBody] OrderUpdateReq request)
        {
            var data = _service.Update(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Delete Order
        [HttpDelete]
        public IActionResult Delete([FromBody] OrderDeleteReq key)
        {
            var data = _service.Delete(key);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Hold Order
        [HttpPut("hold")]
        public IActionResult Hold([FromBody] Key request)
        {
            var data = _service.Hold(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Hold Order
        [HttpPost("getHoldOrder")]
        public IActionResult GetHoldOrder(HoldOrderGetRequest request)
        {
            /*var request = new HoldOrderRequest()
            {
                PosId = posId
            };*/
            var data = _service.GetHoldOrder(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Hold Order
        [HttpPut("cancel")]
        public IActionResult Cancel([FromBody] OrderCancelReq request)
        {
            var data = _service.Cancel(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Hold Order
        [HttpPut("return")]
        public IActionResult Return([FromBody] OrderReturnReq request)
        {
            var data = _service.Return(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Hold Order
        [HttpPost("getOrderReturn")]
        public IActionResult GetReturnOrder([FromBody] OrderReturnReq request)
        {
            var data = _service.GetReturnOrder(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // Hold Order
        [HttpPut("holdToOrder")]
        public IActionResult UpdateHoldToOrder([FromBody] HoldOrderUpdateReq request)
        {
            var data = _service.UpdateHoldToOrder(request);
            if (data?.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
