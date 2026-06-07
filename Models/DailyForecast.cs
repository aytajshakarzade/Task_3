using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_3.Models;

[Table("daily_forecast")]
public class DailyForecast
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("city_id")]
    public int CityId { get; set; }

    [Column("forecast_date")]
    public DateTime ForecastDate { get; set; }

    [Column("day_name")]
    public string DayName { get; set; } = "";

    [Column("temperature")]
    public decimal Temperature { get; set; }

    [Column("weather_description")]
    public string WeatherDescription { get; set; } = "";

    [Column("weather_icon")]
    public string WeatherIcon { get; set; } = "";
}