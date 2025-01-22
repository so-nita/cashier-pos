using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/customerType")]
    public class CustomerTypeController : Controller
    {
        private ICustomerTypeService _service;

        public CustomerTypeController(ICustomerTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest("Something Went wrong");
            }
            return Ok(data);
        }
    }
}
