using Microsoft.AspNetCore.Mvc;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.RequestModel.Receipt;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/orderPayment")]
    public class OrderPaymentController : Controller
    {
        private readonly IOrderPaymentService _service;

        public OrderPaymentController(IOrderPaymentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll ()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("getById")]
        public IActionResult Get([FromBody] Key key)
        {
            var data = _service.Read(key);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create([FromBody] OrderPaymentCreateReq request)
        {
            var data = _service.Create(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("payWithPrintInvoice")]
        public IActionResult CreateWithInvoice([FromBody] OrderPaymentCreateReq request)
        {
            var data = _service.CreatePaymentWithInvoice(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("paymentForReturn")]
        public IActionResult CreateReturnInvoice([FromBody] OrderPaymentReturnReq request)
        {
            var data = _service.CreatePaymentForReturn(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Update([FromBody] OrderPaymentUpdateReq request)
        {
            var data = _service.Update(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpDelete]    
        public IActionResult Delete([FromBody] Key key)
        {
            var data = _service.Delete(key);
            if(data.Status != (int)ResponseStatus.Fail)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        
    }
}
