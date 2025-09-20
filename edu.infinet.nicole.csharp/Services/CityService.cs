using Microsoft.EntityFrameworkCore;
using edu.infinet.nicole.csharp.Data;
using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Services
{
    public class CityService : ICityService
    {
        private readonly CityBreaksContext _context;

        public CityService(CityBreaksContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities
                .Include(c => c.Country)
                .Include(c => c.Properties)
                .ToListAsync();
        }
        
        public async Task<City?> GetByNameAsync(string name)
        {
            return await _context.Cities
                .Include(c => c.Country)
                .Include(c => c.Properties)
                .FirstOrDefaultAsync(c => EF.Functions.Collate(c.Name, "NOCASE") == name);
        }
    }
}