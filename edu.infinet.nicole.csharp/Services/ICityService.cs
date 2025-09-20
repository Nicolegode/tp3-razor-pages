using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
        Task<City?> GetByNameAsync(string name);
        Task AddPropertyAsync(Property property);
        Task DeletePropertyAsync(int id);
        Task<Property?> GetPropertyByIdAsync(int id);
        Task UpdatePropertyAsync(Property property); 
        Task<List<City>> GetCitiesForDropdownAsync();
    }
}