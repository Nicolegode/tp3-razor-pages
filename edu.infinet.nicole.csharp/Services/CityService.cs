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

        public async Task AddPropertyAsync(Property property)
        {
            _context.Properties.Add(property);
            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetCitiesForDropdownAsync()
        {
            return await _context.Cities
                .OrderBy(c => c.Name)
                .ToListAsync();
        }
        
        public async Task<Property?> GetPropertyByIdAsync(int id)
        {
            return await _context.Properties.FindAsync(id);
        }

        public async Task UpdatePropertyAsync(Property property)
        {
            _context.Properties.Update(property);
            await _context.SaveChangesAsync();
        }
        
        public async Task DeletePropertyAsync(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            
            if (property != null)
            {
                property.DeletedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Property>> GetFilteredAsync(decimal? minPrice, decimal? maxPrice, string? cityName, string? propertyName)
        {
            IQueryable<Property> query = _context.Properties
                .Include(p => p.City)
                .ThenInclude(c => c.Country);

            if (minPrice.HasValue)
            {
                query = query.Where(p => p.PricePerNight >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.PricePerNight <= maxPrice.Value);
            }

            if (!string.IsNullOrWhiteSpace(cityName))
            {
                query = query.Where(p => EF.Functions.Collate(p.City.Name, "NOCASE").Contains(cityName));
            }

            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                query = query.Where(p => EF.Functions.Collate(p.Name, "NOCASE").Contains(propertyName));
            }

            return await query
                .OrderBy(p => p.Name)
                .ToListAsync();
        }
    }
}