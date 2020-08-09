using System;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("orders")]
[Produces("text/json")]
public class OrdersController : ControllerBase
{
    [HttpGet("{id:int}")] // constrained parameter
    public IActionResult Get(int id)
    {
        return Ok("{id:int} = " + id);
    }

    [HttpGet("details")]  // literal
    public IActionResult GetDetails()
    {
        return Ok("details");
    }

    [HttpGet("pending", Order = 1)]
    public IActionResult GetPending()
    {
        return Ok("pending");
    }

    [HttpGet("{customerName}")]  // unconstrained parameter
    public IActionResult GetByCustomer(string customerName)
    {
        return Ok("{customerName} = " + customerName);
    }

    [HttpGet("{*date:datetime}")]  // wildcard
    public IActionResult Get(DateTime date)
    {
        return Ok("{*date:datetime} = " + date);
    }
}
