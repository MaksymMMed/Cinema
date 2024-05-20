using Cinema.BLL.DTOs.Tickets;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace Cinema.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class PurchaseController : ControllerBase
{
    private readonly IPurchaseService _purchaseService;
    private readonly IConfiguration _configuration;
        
    public PurchaseController(IPurchaseService purchaseService, IConfiguration configuration)
    {
        _purchaseService = purchaseService;
        _configuration = configuration;
    }
    
    [HttpGet("success")]
    public Task<IActionResult> Success()
    {
        return Task.FromResult<IActionResult>(Ok("The purchase was paid successfully"));
    }
    
    [HttpGet("canceled")]
    public Task<IActionResult> Canceled()
    {
        return Task.FromResult<IActionResult>(Ok("The payment was canceled("));
    }
    
    [Authorize]
    [HttpPost("tickets")]
    public async Task<IActionResult> PurchaseTickets([FromBody] CreateTicketsDto model)
    {
        var result = await _purchaseService.PurchaseTickets(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPost("webhook")]
    public async Task<IActionResult> StripeEventWebhook()
    {
        var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
        var endpointSecret = _configuration["Payments:Stripe:EndpointSecret"];
        var signatureHeader = Request.Headers["Stripe-Signature"];
        var stripeEvent = EventUtility.ConstructEvent(json, signatureHeader, endpointSecret);
        var result = await _purchaseService.HandleStripeWebhookEvent(stripeEvent);
        
        if (!result.IsSuccess)
            return BadRequest(result.Error);
        
        return Ok(result.Value);
    }
}