using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.Filtering.Invoices;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class InvoicesController : ControllerBase
{
    private readonly IInvoicesService _invoicesService;
        
    public InvoicesController(IInvoicesService invoicesService)
    {
        _invoicesService = invoicesService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] InvoicesFilteringModel model)
    {
        var result = await _invoicesService.Get(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _invoicesService.GetById(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] InvoiceCreateDto model)
    {
        var result = await _invoicesService.Create(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPatch("{id}/payment-status/{isPaid}")]
    public async Task<IActionResult> UpdatePaymentStatus(Guid id, bool isPaid)
    {
        var result = await _invoicesService.UpdatePaymentStatus(id, isPaid);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _invoicesService.Delete(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
}