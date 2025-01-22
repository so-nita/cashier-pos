using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Name).IsUnique();

            builder.Property(e=>e.Id).IsRequired()
                                     .HasColumnType("varchar")
                                     .HasMaxLength(36);

            builder.Property(e => e.Code)
                                     .HasColumnType("int")
                                     .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder.Property(e => e.Name).IsRequired()
                                     .HasColumnType("varchar")
                                     .HasMaxLength(50);

            builder.Property(e => e.Description).IsRequired(false)
                                     .HasColumnType("nvarchar")
                                     .HasMaxLength(255);

            builder.Property(e => e.CreatedAt).IsRequired()
                                     .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                     .HasColumnType("int")
                                     .HasConversion<int>();

            builder.Property(e => e.IsDeleted).IsRequired()
                                     .HasColumnType("bit");
        }
    }
}
