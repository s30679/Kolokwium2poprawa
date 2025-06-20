using Microsoft.EntityFrameworkCore;

namespace Kolokwium2poprawa.DAL;

public class MyDbContext : DbContext
{
    public DbSet<Title> Titles { get; set; }

    protected MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}