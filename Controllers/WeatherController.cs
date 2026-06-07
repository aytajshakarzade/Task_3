using Microsoft.AspNetCore.Mvc;
using Task_3.Data;
using Task_3.Views;

[ApiController]
[Route("api/weather")]
public class WeatherController : ControllerBase
{
    private readonly CityRepository _cityRepository;
    private readonly WeatherRepository _weatherRepository;
    private readonly ForecastRepository _forecastRepository;
    private readonly HourlyRepository _hourlyRepository;

    public WeatherController(
        CityRepository cityRepository,
        WeatherRepository weatherRepository,
        ForecastRepository forecastRepository,
        HourlyRepository hourlyRepository)
    {
        _cityRepository = cityRepository;
        _weatherRepository = weatherRepository;
        _forecastRepository = forecastRepository;
        _hourlyRepository = hourlyRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetWeather([FromQuery] string city)
    {
        if (string.IsNullOrWhiteSpace(city))
        {
            return BadRequest(
                WeatherView.FormatError(
                    400,
                    "City parameter is required"));
        }

        var cityEntity = await _cityRepository.FindByName(city);

        if (cityEntity == null)
        {
            return NotFound(
                WeatherView.FormatError(
                    404,
                    "City not found"));
        }

        var current =
            await _weatherRepository.FindByCityId(cityEntity.Id);
        if (current == null)
        {
            return NotFound(
                WeatherView.FormatError(404, "Weather data not found"));
        }

        var forecast =
            await _forecastRepository.FindByCityId(cityEntity.Id);

        var hourly =
            await _hourlyRepository.FindByCityId(cityEntity.Id);

        return Ok(
            WeatherView.FormatSuccess(
                cityEntity,
                current,
                forecast,
                hourly));
    }
}