using Kolokwium2poprawa.DAL;
using Kolokwium2poprawa.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2poprawa.Services;

public class RacersService : IRacersService
{
    private readonly RacesDbContext _dbcontext;

    public RacersService(RacesDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<GetRacerDTO?> GetRacerByIdAsync(int Id, CancellationToken cancellationToken)
    {
        var racer = await _dbcontext.Racers
            .Include(rp => rp.RaceParticipations)
            .ThenInclude(r => r.Racer)
            .FirstOrDefaultAsync(t => t.RacerId == Id, cancellationToken);
        var trackrace = _dbcontext.Races
            .Include(t => t.TrackRaces)
            .ThenInclude(rp => rp.RaceParticipations)
            .ThenInclude(r => r.Racer)
            .First();
        var track = _dbcontext.Tracks
            .Include(t => t.TrackRaces)
            .ThenInclude(rp => rp.RaceParticipations)
            .ThenInclude(r => r.Racer)
            .First();
        var trackrace2 = _dbcontext.Track_Races
            .Include(rp => rp.RaceParticipations)
            .ThenInclude(r => r.TrackRace)
            .First();
        var trackrace3 = _dbcontext.Race_Participations
            .Include(r => r.Racer)
            .First();
        if (racer == null)
        {
            return null;
        }

        return new GetRacerDTO
        {
            racerId = racer.RacerId,
            firstName = racer.FirstName,
            lastName = racer.LastName,
            //Zakomentowane ze względu na problem z konwersją DTO
            // races = racer.RaceParticipations.Select(r => new ParticipationsDTO
            // {
            //     races = new RaceDTO
            //     {
            //         name = trackrace.Name,
            //         location = trackrace.Location,
            //         date = trackrace.Date,
            //     },
            //     tracks = new TrackDTO
            //     {
            //         name = track.Name,
            //         lengthInKm = track.LengthInKm
            //     },
            //     laps = trackrace2.Laps,
            //     finishTimeInSeconds = trackrace3.FinishTimeInSeconds,
            //     position = trackrace3.Position
            // }).ToList()
        };
    }
}
