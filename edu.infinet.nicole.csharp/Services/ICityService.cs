using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
    }
}