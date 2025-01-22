using Microsoft.AspNetCore.Mvc;
using CashierPOS.WebApi.Interface.ISubCategory;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.SubCategory;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController] [Route("api/subcategory")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _service;

        public SubCategoryController(ISubCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            var data = _service.ReadAll();
            if (data!.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost("getById")]
        public IActionResult Read([FromBody] Key key)
        {
            var data = _service.Read(key);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SubCategoryCreateReq req)
        {
            var data = _service.Create(req);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SubCategoryUpdateReq req)
        {
            var data = _service.Update(req);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult Delete(Key key)
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
