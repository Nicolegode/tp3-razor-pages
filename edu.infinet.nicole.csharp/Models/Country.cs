using System.ComponentModel.DataAnnotations;

namespace edu.infinet.nicole.csharp.Models
{
    public class Country
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Code { get; set; } = string.Empty;
        
        public long Population { get; set; }
        
        public string? Capital { get; set; }
    }
}