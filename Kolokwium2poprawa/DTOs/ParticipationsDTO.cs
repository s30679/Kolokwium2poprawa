namespace Kolokwium2poprawa.DTOs;

public class ParticipationsDTO
{
    public RaceDTO races { get; set; }
    public TrackDTO tracks { get; set; }
    public int laps { get; set; }
    public int finishTimeInSeconds { get; set; }
    public int position { get; set; }
}