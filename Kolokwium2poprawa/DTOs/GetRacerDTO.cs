namespace Kolokwium2poprawa.DTOs;

public class GetRacerDTO
{
    public int racerId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public List<ParticipationsDTO> races { get; set; }
}