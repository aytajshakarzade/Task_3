using Microsoft.EntityFrameworkCore;
using Task_3.Models;

namespace Task_3.Data
{
    public class ForecastRepository
    {
        private readonly AppDbContext _context;

        public ForecastRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DailyForecast>> FindByCityId(int cityId)
        {
            return await _context.DailyForecast
                .Where(x => x.CityId == cityId)
                .OrderBy(x => x.ForecastDate)
                .ToListAsync();
        }
    }
}
