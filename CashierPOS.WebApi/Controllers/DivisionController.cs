using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/division")]
    public class DivisionController : Controller
    {
        private readonly IDivisionService _service;

        public DivisionController(IDivisionService service)
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

        [HttpGet("getByProduct")]
        public IActionResult GetAllByProduct()
        {
            var data = _service.ReadAllByProduct();
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
