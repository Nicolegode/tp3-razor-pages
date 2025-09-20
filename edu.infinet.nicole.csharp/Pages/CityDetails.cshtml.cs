// Pages/CityDetails.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using edu.infinet.nicole.csharp.Models;
using edu.infinet.nicole.csharp.Services;

namespace edu.infinet.nicole.csharp.Pages
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService _cityService;

        public CityDetailsModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public City? City { get; set; }

        public async Task OnGetAsync(string name)
        {
            City = await _cityService.GetByNameAsync(name);
        }
    }
}