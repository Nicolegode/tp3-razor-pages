using Microsoft.AspNetCore.Mvc.RazorPages;
using edu.infinet.nicole.csharp.Models;
using edu.infinet.nicole.csharp.Services;

namespace edu.infinet.nicole.csharp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICityService _cityService;

        public IndexModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public List<City> Cities { get; set; } = new();

        public async Task OnGetAsync()
        {
            Cities = await _cityService.GetAllAsync();
        }
    }
}