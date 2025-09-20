using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using edu.infinet.nicole.csharp.Models;
using edu.infinet.nicole.csharp.Data;

namespace edu.infinet.nicole.csharp.Pages
{
    public class EditPropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public EditPropertyModel(CityBreaksContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public int PropertyId { get; set; }

        [BindProperty]
        public string PropertyName { get; set; } = "";

        [BindProperty]
        public int PropertyCityId { get; set; }
        
        public Property Property { get; set; } = new();
        public List<City> Cities { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Property = await _context.Properties.FindAsync(id);
            
            if (Property == null)
            {
                return NotFound();
            }
            
            PropertyId = Property.Id;
            PropertyName = Property.Name;
            PropertyCityId = Property.CityId;

            Cities = _context.Cities.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var existingProperty = await _context.Properties.FindAsync(PropertyId);
            
            if (existingProperty == null)
            {
                return NotFound();
            }
            
            existingProperty.Name = PropertyName;
            existingProperty.CityId = PropertyCityId;

            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}