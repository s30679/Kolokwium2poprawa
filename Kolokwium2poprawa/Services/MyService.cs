using Kolokwium2poprawa.DAL;

namespace Kolokwium2poprawa.Services;

public class MyService : IMyService
{
    private readonly MyDbContext _dbcontext;

    public MyService(MyDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }
    
}