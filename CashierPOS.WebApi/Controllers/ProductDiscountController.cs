using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.DiscountProduct;
using CashierPOS.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/productDiscount")]
    public class ProductDiscountController : Controller
    {
        private readonly IProductDiscountService _service;

        public ProductDiscountController(IProductDiscountService service)
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

        /*[HttpPost("getById")]
        public IActionResult GetById([FromBody])
        {
            var data = _service.Read();
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }*/

        [HttpPost]
        public IActionResult Create([FromBody] DiscountProductCreateReq request)
        {
            var data = _service.Create(request);
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Update([FromBody] DicountProductUpdateReq request)
        {
            var data = _service.Update(request);
            if (data.Status == (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPut("active")]
        public IActionResult Active([FromBody] DiscountProductActiveReq request)
        {
            var data = _service.ActiveDiscount(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }


        [HttpPut("inactive")]
        public IActionResult UnActive([FromBody] DiscountProductActiveReq request)
        {
            var data = _service.InActiveDiscount(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }


    }
}
