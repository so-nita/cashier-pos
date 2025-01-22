using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/discount")]
    public class DicountTypeController : Controller
    {
        private readonly IDicountTypeService _service;

        public DicountTypeController(IDicountTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
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
