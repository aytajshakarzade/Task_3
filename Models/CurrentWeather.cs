using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_3.Models;

[Table("current_weather")]
public class CurrentWeather
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("city_id")]
    public int CityId { get; set; }

    [Column("temperature")]
    public decimal Temperature { get; set; }

    [Column("feels_like")]
    public decimal FeelsLike { get; set; }

    [Column("wind_speed")]
    public decimal WindSpeed { get; set; }

    [Column("wind_direction")]
    public string WindDirection { get; set; } = string.Empty;

    [Column("pressure")]
    public int Pressure { get; set; }

    [Column("humidity")]
    public int Humidity { get; set; }

    [Column("uv_index")]
    public decimal UvIndex { get; set; }

    [Column("visibility_km")]
    public decimal VisibilityKm { get; set; }

    [Column("visibility_condition")]
    public string VisibilityCondition { get; set; } = string.Empty;

    [Column("dew_point")]
    public decimal DewPoint { get; set; }

    [Column("sunrise_time")]
    public TimeSpan SunriseTime { get; set; }

    [Column("sunset_time")]
    public TimeSpan SunsetTime { get; set; }

    [Column("weather_description")]
    public string WeatherDescription { get; set; } = string.Empty;

    [Column("weather_icon")]
    public string WeatherIcon { get; set; } = string.Empty;

    [Column("recorded_at")]
    public DateTime RecordedAt { get; set; }
}