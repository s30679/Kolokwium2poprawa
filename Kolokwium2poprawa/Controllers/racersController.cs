using Kolokwium2poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2poprawa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class racersController : ControllerBase
{
    private readonly IMyService _myService;

    public racersController(IMyService myService)
    {
        _myService = myService;
    }

    // [HttpGet("{Id}/participations")]
    // public async Task<IActionResult> GetByIdAsync(int Id, CancellationToken cancellationToken)
    // {
    //     
    // }
}