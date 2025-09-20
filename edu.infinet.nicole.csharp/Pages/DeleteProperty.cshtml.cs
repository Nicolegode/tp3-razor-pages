using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using edu.infinet.nicole.csharp.Models;
using edu.infinet.nicole.csharp.Services;

namespace edu.infinet.nicole.csharp.Pages
{
    public class DeletePropertyModel : PageModel
    {
        private readonly ICityService _cityService;

        public DeletePropertyModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public Property Property { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var property = await _cityService.GetPropertyByIdAsync(id);
            
            if (property == null)
            {
                return NotFound();
            }

            Property = property;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _cityService.DeletePropertyAsync(id);
            return RedirectToPage("/Index");
        }
    }
}