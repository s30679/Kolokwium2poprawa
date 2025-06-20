using System.ComponentModel.DataAnnotations;

namespace Kolokwium2poprawa.Models;

public class Track
{
    [Key]
    public int TrackId { get; set; }
    
    [Required, MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    public decimal LengthInKm { get; set; }
    public ICollection<Track_Race> TrackRaces { get; set; }
}