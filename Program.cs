using Microsoft.EntityFrameworkCore;
using Task_3.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection"));
});

builder.Services.AddScoped<CityRepository>();
builder.Services.AddScoped<WeatherRepository>();
builder.Services.AddScoped<ForecastRepository>();
builder.Services.AddScoped<HourlyRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors("Frontend");

app.MapControllers();

app.Run();