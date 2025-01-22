using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class SystemTypeConfig : IEntityTypeConfiguration<SystemType>
    { 
        public void Configure(EntityTypeBuilder<SystemType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Name).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(e => e.Create_At).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.Status).IsRequired().HasColumnType("varchar").HasMaxLength(20);
            builder.Property(e => e.Is_Deleted).IsRequired(false).HasColumnType("bit");
        }
    }
}
