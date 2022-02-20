namespace SeptaTracker.Services;
using SeptaTracker.Models;
public sealed class SeptaService
{
    private readonly HttpClient _httpClient = null!;
    private readonly ILogger<SeptaService> _logger = null!;

    private readonly string SEPTA_API_URL = "https://www3.septa.org/api/TrainView/";

    public SeptaService(HttpClient httpClient, ILogger<SeptaService> logger)
        => (httpClient, logger) = (_httpClient, _logger);

    public async Task<List<SeptaData>> GetSeptaDataAsync()
    {
        var result = new List<SeptaData>();
        try
        {
            result = await _httpClient.GetFromJsonAsync<List<SeptaData>>(SEPTA_API_URL);
            if (result is not null)
            {
                return result;
            }
        }
        catch (Exception ex)
        {
            _logger.Log(LogLevel.Warning, $"SEPTA API not returning data; error: {ex.Message}");
        }
        return result;
    }
}