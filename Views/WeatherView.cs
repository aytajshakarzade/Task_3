using Task_3.Models;

namespace Task_3.Views
{
    public static class WeatherView
    {
        public static object FormatSuccess(
            City city,
            CurrentWeather current,
            List<DailyForecast> forecast,
            List<HourlyData> hourly)
        {
            return new
            {
                success = true,
                message = "OK",
                data = new
                {
                    city = new
                    {
                        name = city.Name,
                        country_code = city.CountryCode,
                        country_name = city.CountryName
                    },

                    current,

                    weekly_forecast = forecast,

                    hourly
                }
            };
        }

        public static object FormatError(int statusCode, string message)
        {
            return new
            {
                success = false,
                statusCode,
                message
            };
        }
    }
}
