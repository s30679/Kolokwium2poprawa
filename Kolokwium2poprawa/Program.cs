using System.Text.Json.Serialization;
using Kolokwium2poprawa.DAL;
using Kolokwium2poprawa.Services;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2poprawa;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        string? connectionString = builder.Configuration.GetConnectionString("db-mssql");
        
        // Add services to the container.
        builder.Services.AddAuthorization();
        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            options.JsonSerializerOptions.WriteIndented = true;
        });
        builder.Services.AddDbContext<MyDbContext>(optionsBuilder =>
        {
            optionsBuilder.UseSqlServer(connectionString);
        });
        builder.Services.AddScoped<IMyService, MyService>();
        
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}