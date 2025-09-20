using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Services
{
    public interface IPropertyService
    {
        Task<bool> CreateAsync(Property property);
    }
}