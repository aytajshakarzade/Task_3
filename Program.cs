using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Task_3.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<CityRepository>();
builder.Services.AddScoped<WeatherRepository>();
builder.Services.AddScoped<ForecastRepository>();
builder.Services.AddScoped<HourlyRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Weather API",
        Version = "v1",
        Description = "Weather information service"
    });
});

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint(
        "/swagger/v1/swagger.json",
        "Weather API v1");

    options.RoutePrefix = "docs";
});

app.UseCors("Frontend");

app.MapControllers();

app.Run();