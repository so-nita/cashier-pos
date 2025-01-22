using Azure.Core;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Brand;
using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Interfaces;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/brand")]
    public class BrandsController : Controller
    {
        private readonly IProductBrand _service;

        public BrandsController(IProductBrand service)
        {
            _service = service;
        }

        // GET: BrandsController
        [HttpGet]
        public ActionResult Get()
        {
            var data = _service.ReadAll();
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // GET: BrandsController/Details/5
        [HttpGet("{brandId}")]
        public ActionResult Details([FromRoute] string brandId)
        {
            var request = new Key()
            {
                Id = brandId,
            };
            var data = _service.Read(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }


        // POST: BrandsController/Create
        [HttpPost]
        public ActionResult Create([FromBody] BrandCreateReq request)
        {
            var data = _service.Create(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        // GET: BrandsController/Edit/5
        [HttpPut]
        public ActionResult Edit([FromBody] BrandUpdateReq request)
        {
            var data = _service.Update(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }


        // GET: BrandsController/Delete/5
        [HttpPut("disable")]
        public ActionResult Disable([FromBody] BrandDeleteReq request)
        {
            var data = _service.Delete(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

         
    }
}
