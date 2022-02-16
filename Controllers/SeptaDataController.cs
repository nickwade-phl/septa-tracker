using Microsoft.AspNetCore.Mvc;
using SeptaTracker.Models;

namespace SeptaTracker.Controllers;

[ApiController]
[Route("[controller]")]
public class SeptaDataController : ControllerBase
{
    private readonly ILogger<SeptaData> _logger;

    public SeptaDataController(ILogger<SeptaData> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSeptaData")]
    public IEnumerable<SeptaData> Get()
    {
        var result = new List<SeptaData>();
        return result;
    }
}
