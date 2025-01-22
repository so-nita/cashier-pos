using Microsoft.AspNetCore.Mvc;
using CashierPOS.Model.Interface;
using CashierPOS.WebApi.Models;
using CashierPOS.Model.Models.Category;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models;

namespace CashierPOS.WebApi.Controllers;

[ApiController] 
[Route("api/category")]
public class CategoryController : Controller
{
    private readonly ICategoryService _service;

    public CategoryController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var data = _service.ReadAll();
        if(data!.Status!=(int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPost("getById")]
    public IActionResult GetById([FromBody] Key key)
    {
        var data = _service.Read(key);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CategoryCreateReq req)
    {
        var data = _service.Create(req);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpPut]
    public IActionResult Update([FromBody] CategoryUpdateReq req)
    {
        var data = _service.Update(req);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }

    [HttpDelete]
    public IActionResult Delete([FromBody] Key key)
    {
        var data = _service.Delete(key);
        if (data!.Status != (int)ResponseStatus.Success)
        {
            return BadRequest(data);
        }
        return Ok(data);
    }
}
