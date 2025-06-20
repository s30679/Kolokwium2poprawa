using Kolokwium2poprawa.DTOs;

namespace Kolokwium2poprawa.Services;

public interface IRacersService
{
    Task<GetRacerDTO?> GetRacerByIdAsync(int Id, CancellationToken cancellationToken);
}