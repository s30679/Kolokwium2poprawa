using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2poprawa.Models;

public class Race_Participation
{
    [Key, Column(Order = 0)]
    public int TrackRaceId { get; set; }
    
    [Key, Column(Order = 1)]
    public int RacerId { get; set; }
    
    [Required]
    public int FinishTimeInSeconds { get; set; }
    
    [Required]
    public int Position { get; set; }
    
    [ForeignKey(nameof(TrackRaceId))]
    public Track_Race TrackRace { get; set; }
    
    [ForeignKey(nameof(RacerId))]
    public Racer Racer { get; set; }
}