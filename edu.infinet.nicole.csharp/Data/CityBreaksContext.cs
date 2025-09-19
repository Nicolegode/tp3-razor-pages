using Microsoft.EntityFrameworkCore;
using edu.infinet.nicole.csharp.Models;
using edu.infinet.nicole.csharp.Data.Configurations;

namespace edu.infinet.nicole.csharp.Data
{
    public class CityBreaksContext : DbContext
    {
        public CityBreaksContext(DbContextOptions<CityBreaksContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; } = default!;
        public DbSet<City> Cities { get; set; } = default!;
        public DbSet<Property> Properties { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyConfiguration());
        }
    }
}