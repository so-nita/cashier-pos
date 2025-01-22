using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/reasonType")]
    public class ReasonTypeController : Controller
    {
        private readonly IReasonTypeService _service;

        public ReasonTypeController(IReasonTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
