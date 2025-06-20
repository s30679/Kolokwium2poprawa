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
            .ThenInclude(tr => tr.TrackRace)
            .ThenInclude(r => r.Race)
            .Include(r=>r.RaceParticipations)
            .ThenInclude(tr=>tr.TrackRace)
            .ThenInclude(t=>t.Track)
            .FirstOrDefaultAsync(t => t.RacerId == Id, cancellationToken);
        if (racer == null)
        {
            return null;
        }

        return new GetRacerDTO
        {
            racerId = racer.RacerId,
            firstName = racer.FirstName,
            lastName = racer.LastName,
            races = racer.RaceParticipations.Select(r => new ParticipationsDTO
            {
                races = new RaceDTO 
                {
                     name = r.TrackRace.Race.Name,
                     location = r.TrackRace.Race.Location,
                     date = r.TrackRace.Race.Date
                 },
                 tracks = new TrackDTO
                 {
                     name = r.TrackRace.Track.Name,
                     lengthInKm = r.TrackRace.Track.LengthInKm
                 },
                 laps = r.TrackRace.Laps,
                 finishTimeInSeconds = r.FinishTimeInSeconds,
                 position = r.Position
             }).ToList()
        };
    }
}
