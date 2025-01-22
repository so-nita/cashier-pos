using Microsoft.AspNetCore.Mvc;
using CashierPOS.WebApi.Interface.Product;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Product;

namespace CashierPOS.Model.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : Controller
{
    private readonly IProductService _service;
    public ProductController(IProductService service)
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

    [HttpGet("getForSell")]
    public IActionResult GetProductSell()
    {
        var data = _service.GetProductSell();
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPost("getById")]
    public IActionResult Get(Key key)
    {
        var data = _service.Read(key);
        if (data.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPost]
    public IActionResult Create(ProductCreateReq req)
    {
        var data = _service.Create(req);
        if (data.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPut]
    public IActionResult Update(ProductUpdateReq req)
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

    [HttpPut("reactive")]
    public IActionResult Reactive(Key key)
    {
        /*var data = _service.Update(req);
        if (data.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }*/
        return Ok();
    }
}
