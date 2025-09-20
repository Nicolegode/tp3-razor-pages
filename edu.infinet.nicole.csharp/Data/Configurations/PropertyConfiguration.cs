using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using edu.infinet.nicole.csharp.Models;

namespace edu.infinet.nicole.csharp.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(200)
                .HasColumnName("PropertyName");
            
            builder.Property(p => p.DeletedAt)
                .IsRequired(false);
            
            builder.HasQueryFilter(p => p.DeletedAt == null);
            
            builder.HasData(
                new Property { Id = 1, Name = "Hotel Copacabana Palace", PricePerNight = 800.00m, CityId = 1 },
                new Property { Id = 2, Name = "Apartamento Vista Cristo Redentor", PricePerNight = 450.00m, CityId = 1 },
                new Property { Id = 3, Name = "Pousada Ipanema Beach", PricePerNight = 280.00m, CityId = 1 },
                new Property { Id = 4, Name = "Hotel Unique", PricePerNight = 650.00m, CityId = 2 },
                new Property { Id = 5, Name = "Apartamento Vila Madalena", PricePerNight = 320.00m, CityId = 2 },
                new Property { Id = 6, Name = "Hotel Alvear Palace", PricePerNight = 420.00m, CityId = 3 },
                new Property { Id = 7, Name = "Loft em Palermo", PricePerNight = 180.00m, CityId = 3 },
                new Property { Id = 8, Name = "Pousada Vinícola Andina", PricePerNight = 280.00m, CityId = 4 },
                new Property { Id = 9, Name = "Hotel Le Meurice", PricePerNight = 950.00m, CityId = 5 },
                new Property { Id = 10, Name = "Apartamento Champs-Élysées", PricePerNight = 520.00m, CityId = 5 },
                new Property { Id = 11, Name = "Hotel Negresco", PricePerNight = 580.00m, CityId = 6 },
                new Property { Id = 12, Name = "Hotel Casa Fuster", PricePerNight = 520.00m, CityId = 7 },
                new Property { Id = 13, Name = "Apartamento Gòtic", PricePerNight = 290.00m, CityId = 7 },
                new Property { Id = 14, Name = "Hotel Alfonso XIII", PricePerNight = 380.00m, CityId = 8 },
                new Property { Id = 15, Name = "Hotel de Russie", PricePerNight = 720.00m, CityId = 9 },
                new Property { Id = 16, Name = "B&B Trastevere", PricePerNight = 150.00m, CityId = 9 },
                new Property { Id = 17, Name = "Hotel Brunelleschi", PricePerNight = 480.00m, CityId = 10 },
                new Property { Id = 18, Name = "Hotel Tivoli Oriente", PricePerNight = 320.00m, CityId = 11 },
                new Property { Id = 19, Name = "Hostel Alfama", PricePerNight = 85.00m, CityId = 11 },
                new Property { Id = 20, Name = "Pestana Vintage Porto", PricePerNight = 250.00m, CityId = 12 },
                new Property { Id = 21, Name = "The Plaza Hotel", PricePerNight = 1200.00m, CityId = 13 },
                new Property { Id = 22, Name = "Apartamento Manhattan", PricePerNight = 680.00m, CityId = 13 },
                new Property { Id = 23, Name = "The Setai Miami Beach", PricePerNight = 850.00m, CityId = 14 },
                new Property { Id = 24, Name = "Fairmont Royal York", PricePerNight = 420.00m, CityId = 15 },
                new Property { Id = 25, Name = "Hotel Vancouver", PricePerNight = 380.00m, CityId = 16 },
                new Property { Id = 26, Name = "Grand Fiesta Americana", PricePerNight = 550.00m, CityId = 17 },
                new Property { Id = 27, Name = "Resort All Inclusive Cancún", PricePerNight = 380.00m, CityId = 17 },
                new Property { Id = 28, Name = "Rosewood Mayakoba", PricePerNight = 920.00m, CityId = 18 },
                new Property { Id = 29, Name = "Hotel Singular Santiago", PricePerNight = 350.00m, CityId = 19 },
                new Property { Id = 30, Name = "Casa Higueras Hotel", PricePerNight = 280.00m, CityId = 20 }
            );
        }
    }
}