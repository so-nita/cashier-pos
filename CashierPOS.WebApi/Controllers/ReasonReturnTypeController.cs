using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.ReasonType;
using CashierPOS.Model.Models.Response;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/reasonReturnType")]
    public class ReasonReturnTypeController : Controller
    {
        private readonly IReasonReturnTypeService _service;
        public ReasonReturnTypeController(IReasonReturnTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.ReadAll();
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }



}
