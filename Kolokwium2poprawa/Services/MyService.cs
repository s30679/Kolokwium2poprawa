using Kolokwium2poprawa.DAL;

namespace Kolokwium2poprawa.Services;

public class MyService : IMyService
{
    private readonly RacesDbContext _dbcontext;

    public MyService(RacesDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }
    
}