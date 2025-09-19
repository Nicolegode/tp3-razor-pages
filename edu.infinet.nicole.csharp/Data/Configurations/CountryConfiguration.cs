using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .HasColumnName("CountryName");
            
            builder.HasData(
                new Country { Id = 1, Name = "Brasil", Code = "BR", Population = 215000000, Capital = "Brasília" },
                new Country { Id = 2, Name = "Argentina", Code = "AR", Population = 45000000, Capital = "Buenos Aires" },
                new Country { Id = 3, Name = "França", Code = "FR", Population = 68000000, Capital = "Paris" },
                new Country { Id = 4, Name = "Espanha", Code = "ES", Population = 47000000, Capital = "Madrid" },
                new Country { Id = 5, Name = "Itália", Code = "IT", Population = 60000000, Capital = "Roma" },
                new Country { Id = 6, Name = "Portugal", Code = "PT", Population = 10000000, Capital = "Lisboa" },
                new Country { Id = 7, Name = "Estados Unidos", Code = "US", Population = 331000000, Capital = "Washington" },
                new Country { Id = 8, Name = "Canadá", Code = "CA", Population = 38000000, Capital = "Ottawa" },
                new Country { Id = 9, Name = "México", Code = "MX", Population = 128000000, Capital = "Cidade do México" },
                new Country { Id = 10, Name = "Chile", Code = "CL", Population = 19000000, Capital = "Santiago" }
            );
        }
    }
}