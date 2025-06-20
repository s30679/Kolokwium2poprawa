using Kolokwium2poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2poprawa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class racersController : ControllerBase
{
    private readonly IRacersService _racersService;

    public racersController(IRacersService racersService)
    {
        _racersService = racersService;
    }

    [HttpGet("{Id}/participations")]
    public async Task<IActionResult> GetRacerByIdAsync(int Id, CancellationToken cancellationToken)
    {
        var racer = await _racersService.GetRacerByIdAsync(Id, cancellationToken);
        if (racer == null)
        {
            return NotFound();
        }
        return Ok(racer);    
    }
    
}