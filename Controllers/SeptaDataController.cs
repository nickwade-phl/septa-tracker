using Microsoft.AspNetCore.Mvc;
using SeptaTracker.Models;
using SeptaTracker.Services;

namespace SeptaTracker.Controllers;

[ApiController]
[Route("[controller]")]
public class SeptaDataController : ControllerBase
{
    private readonly ILogger<SeptaData> _logger;
    private readonly SeptaService _septaService;
    public SeptaDataController(ILogger<SeptaData> logger, SeptaService septaService)
    {
        _logger = logger;
        _septaService = septaService;
    }

    [HttpGet(Name = "CheckStatus")]
    public async Task<bool> CheckStatus(string railLine)
    {
        var septaData = await _septaService.GetSeptaDataAsync();
        var lineData = septaData.FirstOrDefault(i => i.line == railLine);
        return lineData?.late > 0;
    }
}
