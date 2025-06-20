using System.ComponentModel.DataAnnotations;

namespace Kolokwium2poprawa.Models;

public class Racer
{
    [Key]
    public int RacerId { get; set; }
    
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    
    [Required, MaxLength(100)]
    public string LastName { get; set; }
    public ICollection<Race_Participation> RaceParticipations { get; set; }
}