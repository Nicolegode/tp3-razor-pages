using System.ComponentModel.DataAnnotations;

namespace edu.infinet.nicole.csharp.Models
{
    public class City
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
    }
}