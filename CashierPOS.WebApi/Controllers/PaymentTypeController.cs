using Microsoft.AspNetCore.Mvc;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Services;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/paymentType")]
    public class PaymentTypeController : Controller
    {
        private readonly IPaymentTypeService _service;

        public PaymentTypeController(IPaymentTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.ReadAll();
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

    }
}
