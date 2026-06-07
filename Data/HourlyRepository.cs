using Microsoft.EntityFrameworkCore;
using Task_3.Models;

namespace Task_3.Data
{
    public class HourlyRepository
    {
        private readonly AppDbContext _context;

        public HourlyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<HourlyData>> FindByCityId(int cityId)
        {
            return await _context.HourlyData
                .Where(x => x.CityId == cityId)
                .OrderBy(x => x.HourLabel)
                .ToListAsync();
        }
    }
}
