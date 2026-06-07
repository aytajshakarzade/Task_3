using Microsoft.EntityFrameworkCore;
using Task_3.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }

    public DbSet<CurrentWeather> CurrentWeather { get; set; }

    public DbSet<DailyForecast> DailyForecast { get; set; }

    public DbSet<HourlyData> HourlyData { get; set; }
}