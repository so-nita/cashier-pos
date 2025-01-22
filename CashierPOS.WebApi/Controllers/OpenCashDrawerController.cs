using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Test;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    public class OpenCashDrawerController : Controller
    {
        private readonly IOpenCashDrawerService _service;

        public OpenCashDrawerController(IOpenCashDrawerService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Open([FromBody] CashDrawOpenReq request)
        {
            var data = _service.OpenCashDrawer(request);
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
