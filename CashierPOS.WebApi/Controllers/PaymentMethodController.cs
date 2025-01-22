using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/paymentMethod")]
    public class PaymentMethodController : Controller
    {
        private readonly IPaymentMethodService _service;

        public PaymentMethodController(IPaymentMethodService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpGet("pay")]
        public IActionResult GetForPay()
        {
            var data = _service.ReadPaymentForPay();
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
