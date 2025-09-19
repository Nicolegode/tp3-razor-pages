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
        }
    }
}