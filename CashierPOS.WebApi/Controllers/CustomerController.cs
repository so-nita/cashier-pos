using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Customer;
using CashierPOS.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CustomerCreateReq request)
        {
            var data = _service.Create(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost("getById")]
        public IActionResult Read([FromBody] Key request)
        {
            var data = _service.Read(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
