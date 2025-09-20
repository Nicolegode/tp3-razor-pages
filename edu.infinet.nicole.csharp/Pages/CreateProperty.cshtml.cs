using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using edu.infinet.nicole.csharp.Models;
using edu.infinet.nicole.csharp.Services;

namespace edu.infinet.nicole.csharp.Pages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly ICityService _cityService;

        public CreatePropertyModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        [BindProperty]
        public string PropertyName { get; set; } = "";

        [BindProperty]
        public int CityId { get; set; }

        public List<City> Cities { get; set; } = new();

        public async Task OnGetAsync()
        {
            Cities = await _cityService.GetAllAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var property = new Property
            {
                Name = PropertyName,
                CityId = CityId
            };

            await _cityService.AddPropertyAsync(property);
            return RedirectToPage("/Index");
        }
    }
}