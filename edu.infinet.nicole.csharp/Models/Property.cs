using System.ComponentModel.DataAnnotations;

namespace edu.infinet.nicole.csharp.Models
{
    public class Property
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public decimal PricePerNight { get; set; }
        
        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }
}