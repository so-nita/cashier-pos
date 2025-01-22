using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class CustomerTypeConfig : IEntityTypeConfiguration<CustomerType>
    {
        public void Configure(EntityTypeBuilder<CustomerType> builder)
        {
            builder.HasKey(e => e.Id);
            //builder.HasIndex(e => e.Code).IsUnique();

            builder.Property(e => e.Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

            builder.Property(e => e.Code).IsRequired()
                                     .HasColumnType("varchar")
                                    .HasMaxLength(20);

            builder.Property(e => e.Name).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(100);

            builder.Property(e => e.NameKh).IsRequired(false)
                                    .HasColumnType("nvarchar")
                                    .HasMaxLength(100);

            builder.Property(e => e.Description).IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(255);

            builder.Property(e => e.CreatedAt).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            builder.Property(e => e.IsDeleted).IsRequired().HasColumnType("bit");
        }
    }
}
