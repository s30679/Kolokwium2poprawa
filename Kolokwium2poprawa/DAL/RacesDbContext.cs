using Kolokwium2poprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2poprawa.DAL;

public class RacesDbContext : DbContext
{
    public DbSet<Racer> Racers { get; set; }
    public DbSet<Race_Participation> Race_Participations { get; set; }
    public DbSet<Race> Races { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Track_Race> Track_Races { get; set; }

    protected RacesDbContext()
    {
    }

    public RacesDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Race_Participation>().HasKey(rp => new { rp.TrackRaceId, rp.RacerId});
        
        modelBuilder.Entity<Racer>().HasData(
            new Racer { RacerId = 1, FirstName = "Lewis", LastName = "Hamilton" },
            new Racer { RacerId = 2, FirstName = "Robert", LastName = "Kubica" }
        );
        
        modelBuilder.Entity<Race>().HasData(
            new Race { RaceId = 1, Name = "Warszawa", Location = "A", Date = new DateTime(2025, 8, 2) },
            new Race { RaceId = 2, Name = "Monaco", Location = "B", Date = new DateTime(2025, 9, 9) }
        );

        modelBuilder.Entity<Track>().HasData(
            new Track { TrackId = 1, Name = "Tor1", LengthInKm = 5 },
            new Track { TrackId = 2, Name = "Tor2", LengthInKm = 3 }
        );

        modelBuilder.Entity<Track_Race>().HasData(
            new Track_Race { TrackRaceId = 1, TrackId = 1, RaceId = 1, Laps = 3, BestTimeInSeconds = 30},
            new Track_Race {TrackRaceId = 2, TrackId = 1, RaceId = 2, Laps = 2, BestTimeInSeconds = 20},
            new Track_Race {TrackRaceId = 3, TrackId = 2, RaceId = 1, Laps = 5, BestTimeInSeconds = 90}
        );

        modelBuilder.Entity<Race_Participation>().HasData(
            new Race_Participation { TrackRaceId = 1, RacerId = 1, FinishTimeInSeconds = 40},
            new Race_Participation { TrackRaceId = 2, RacerId = 2, FinishTimeInSeconds = 20},
            new Race_Participation { TrackRaceId = 3, RacerId = 2, FinishTimeInSeconds = 120}
        );
    }
}