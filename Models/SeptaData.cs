namespace SeptaTracker.Models;

public class SeptaData
{
    public string? lat { get; set; }
    public string? lon { get; set; }
    public string? trainno { get; set; }
    public string? service { get; set; }
    public string? dest { get; set; }
    public string? currentstop { get; set; }
    public string? nextstop { get; set; }
    public string? line { get; set; }
    public string? consist { get; set; }
    public double heading { get; set; }
    public bool late { get; set; }
    public string? SOURCE { get; set; }
    public string? TRACK { get; set; }
    public string? TRACK_CHANGE { get; set; }
}
