using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2poprawa.Models;

public class Track_Race
{
    [Key]
    public int TrackRaceId { get; set; }
    
    [Required]
    public int TrackId { get; set; }
    
    [Required]
    public int RaceId { get; set; }
    
    [Required]
    public int Laps { get; set; }
    
    public int? BestTimeInSeconds { get; set; }
    
    [ForeignKey(nameof(TrackId))]
    public Track Track { get; set; }
    
    [ForeignKey(nameof(RaceId))]
    public Race Race { get; set; }
    
    public ICollection<Race_Participation> RaceParticipations { get; set; }
}