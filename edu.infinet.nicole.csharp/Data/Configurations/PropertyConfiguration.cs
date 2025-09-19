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

            // Dados iniciais
            builder.HasData(
                new Property { Id = 1, Name = "Pão de Açúcar", PricePerNight = 280.00m, CityId = 1 },
                new Property { Id = 2, Name = "Cristo Redentor", PricePerNight = 180.00m, CityId = 1 },
                new Property { Id = 3, Name = "MASP", PricePerNight = 220.00m, CityId = 2 },
                new Property { Id = 4, Name = "Caminito", PricePerNight = 150.00m, CityId = 3 },
                new Property { Id = 5, Name = "Aconcágua", PricePerNight = 120.00m, CityId = 4 },
                new Property { Id = 6, Name = "Torre Eiffel", PricePerNight = 450.00m, CityId = 5 },
                new Property { Id = 7, Name = "Promenade des Anglais", PricePerNight = 320.00m, CityId = 6 },
                new Property { Id = 8, Name = "Sagrada Família", PricePerNight = 290.00m, CityId = 7 },
                new Property { Id = 9, Name = "Alcázar de Sevilha", PricePerNight = 160.00m, CityId = 8 },
                new Property { Id = 10, Name = "Coliseu", PricePerNight = 380.00m, CityId = 9 },
                new Property { Id = 11, Name = "Ponte Vecchio", PricePerNight = 340.00m, CityId = 10 },
                new Property { Id = 12, Name = "Torre de Belém", PricePerNight = 140.00m, CityId = 11 },
                new Property { Id = 13, Name = "Livraria Lello", PricePerNight = 110.00m, CityId = 12 },
                new Property { Id = 14, Name = "Estátua da Liberdade", PricePerNight = 520.00m, CityId = 13 },
                new Property { Id = 15, Name = "South Beach", PricePerNight = 380.00m, CityId = 14 },
                new Property { Id = 16, Name = "CN Tower", PricePerNight = 240.00m, CityId = 15 },
                new Property { Id = 17, Name = "Stanley Park", PricePerNight = 200.00m, CityId = 16 },
                new Property { Id = 18, Name = "Chichen Itzá", PricePerNight = 350.00m, CityId = 17 },
                new Property { Id = 19, Name = "Cenotes", PricePerNight = 280.00m, CityId = 18 },
                new Property { Id = 20, Name = "Cerro San Cristóbal", PricePerNight = 160.00m, CityId = 19 },
                new Property { Id = 21, Name = "Casa Pablo Neruda", PricePerNight = 130.00m, CityId = 20 }
            );
        }
    }
}