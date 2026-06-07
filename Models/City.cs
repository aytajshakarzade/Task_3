using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_3.Models;

[Table("cities")]
public class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("country_code")]
    public string CountryCode { get; set; } = string.Empty;

    [Column("country_name")]
    public string CountryName { get; set; } = string.Empty;
}