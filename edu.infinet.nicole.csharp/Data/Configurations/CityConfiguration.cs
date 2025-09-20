using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name)
                .HasColumnName("CityName");

            builder.HasData(
                new City { Id = 1, Name = "Rio de Janeiro", CountryId = 1 },
                new City { Id = 2, Name = "São Paulo", CountryId = 1 },
                new City { Id = 3, Name = "Buenos Aires", CountryId = 2 },
                new City { Id = 4, Name = "Mendoza", CountryId = 2 },
                new City { Id = 5, Name = "Paris", CountryId = 3 },
                new City { Id = 6, Name = "Nice", CountryId = 3 },
                new City { Id = 7, Name = "Barcelona", CountryId = 4 },
                new City { Id = 8, Name = "Sevilha", CountryId = 4 },
                new City { Id = 9, Name = "Roma", CountryId = 5 },
                new City { Id = 10, Name = "Florença", CountryId = 5 },
                new City { Id = 11, Name = "Lisboa", CountryId = 6 },
                new City { Id = 12, Name = "Porto", CountryId = 6 },
                new City { Id = 13, Name = "Nova York", CountryId = 7 },
                new City { Id = 14, Name = "Miami", CountryId = 7 },
                new City { Id = 15, Name = "Toronto", CountryId = 8 },
                new City { Id = 16, Name = "Vancouver", CountryId = 8 },
                new City { Id = 17, Name = "Cancún", CountryId = 9 },
                new City { Id = 18, Name = "Playa del Carmen", CountryId = 9 },
                new City { Id = 19, Name = "Santiago", CountryId = 10 },
                new City { Id = 20, Name = "Valparaíso", CountryId = 10 }
            );
        }
    }
}