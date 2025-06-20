using System.ComponentModel.DataAnnotations;

namespace Kolokwium2poprawa.Models;

public class Race
{
    [Key]
    public int RaceId { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; }
    
    [Required, MaxLength(100)]
    public string Location { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
    public ICollection<Track_Race> TrackRaces { get; set; }
}