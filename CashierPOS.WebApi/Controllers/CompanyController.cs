using Microsoft.AspNetCore.Mvc;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models;
using CashierPOS.WebApi.Models.RequestModel.Company;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController] 
    [Route("api/company")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _service;

        public CompanyController(ICompanyService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Read()
        {
            var data = _service.ReadAll();
            if(data.Status!=(int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);    
        }


        [HttpPost("getById")]
        public IActionResult Create([FromBody] Key key)
        {
            var data = _service.Read(key);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CompanyCreateReq req)
        {
            var data = _service.Create(req);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CompanyUpdateReq req)
        {
            var data = _service.Update(req);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Key key)
        {
            var data = _service.Delete(key);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }
    }
}
