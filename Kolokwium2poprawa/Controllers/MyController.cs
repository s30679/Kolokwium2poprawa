using Kolokwium2poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2poprawa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MyController : ControllerBase
{
    private readonly IMyService _myService;

    public MyController(IMyService myService)
    {
        _myService = myService;
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetByIdAsync(int Id, CancellationToken cancellationToken)
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] cos, CancellationToken cancellationToken)
    {
        
    }
}