﻿using Kolokwium2poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2poprawa.Controllers;

[ApiController]
[Route("api/[controller]")]
public class track_racesController
{
    private readonly IRacersService _racersService;

    public track_racesController(IRacersService racersService)
    {
        _racersService = racersService;
    }
    // [HttpPost("participants")]
    // public async Task<IActionResult> PostAsync([FromBody] cos, CancellationToken cancellationToken)
    // {
    //     
    // }
}