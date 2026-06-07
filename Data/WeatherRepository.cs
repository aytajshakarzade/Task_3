using Microsoft.EntityFrameworkCore;
using Task_3.Models;

namespace Task_3.Data
{
    public class WeatherRepository
    {
        private readonly AppDbContext _context;

        public WeatherRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CurrentWeather?> FindByCityId(int cityId)
        {
            return await _context.CurrentWeather
                .Where(x => x.CityId == cityId)
                .OrderByDescending(x => x.RecordedAt)
                .FirstOrDefaultAsync();
        }
    }
}
