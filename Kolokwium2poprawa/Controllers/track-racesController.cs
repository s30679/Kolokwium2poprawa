using Kolokwium2poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2poprawa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class track_racesController
{
    private readonly IMyService _myService;

    public track_racesController(IMyService myService)
    {
        _myService = myService;
    }
    // [HttpPost("participants")]
    // public async Task<IActionResult> PostAsync([FromBody] cos, CancellationToken cancellationToken)
    // {
    //     
    // }
}