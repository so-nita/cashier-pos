using CashierPOS.WebApi.Interfaces;
using CashierPOS.Model.Models;
using CashierPOS.WebApi.Models.RequestModel.ChangeShift;
using Microsoft.AspNetCore.Mvc;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.ChangeShift;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/changeshift")]
    public class ChangeShiftController : Controller
    {
        private readonly IChangeShiftService _service;

        public ChangeShiftController(IChangeShiftService service)
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

        [HttpPost("open")]
        public IActionResult OpenShift([FromBody] ChangeShiftCreateReq request)
        {
            //var data = _service.Create(request);
            var data = _service.OpenShift(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut("close")]
        public IActionResult CloseShift([FromBody] ChangeShiftCloseReq request)
        {
            var data = _service.CloseShift(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpGet("{shiftId}")]
        public IActionResult SummaryCloseShift(int shiftId)
        {
            var request = new CloseShiftPrintSummaryReq()
            {
                //PosId = posId
                ShiftId = shiftId
            };
            var data = _service.PrintSummaryShift(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Update([FromBody] ChangeShiftUpdateReq request)
        {
            var data = _service.Update(request);
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
