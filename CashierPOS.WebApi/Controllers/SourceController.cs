using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/source")]
    public class SourceController : Controller
    {
        private readonly ISourceService _service;

        public SourceController(ISourceService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.ReadAll();
            if(data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
