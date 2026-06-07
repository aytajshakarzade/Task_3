using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_3.Models;

[Table("hourly_data")]
public class HourlyData
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("city_id")]
    public int CityId { get; set; }

    [Column("hour_label")]
    public string HourLabel { get; set; } = "";

    [Column("wind_speed")]
    public decimal WindSpeed { get; set; }

    [Column("rain_probability")]
    public int RainProbability { get; set; }

    [Column("rain_condition")]
    public string RainCondition { get; set; } = "";
}