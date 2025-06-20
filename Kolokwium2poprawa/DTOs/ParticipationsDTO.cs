namespace Kolokwium2poprawa.DTOs;

public class ParticipationsDTO
{
    public List<RaceDTO> races { get; set; }
    public List<TrackDTO> tracks { get; set; }
    public int laps { get; set; }
    public int finishTimeInSeconds { get; set; }
    public int position { get; set; }
}