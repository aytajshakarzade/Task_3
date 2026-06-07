using Microsoft.EntityFrameworkCore;
using Task_3.Models;

namespace Task_3.Data
{
    public class CityRepository
    {
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<City?> FindByName(string cityName)
        {
            return await _context.Cities
                .FirstOrDefaultAsync(c => c.Name == cityName);
        }
    }
}
