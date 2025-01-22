using CashierPOS.Model.Models.Constant;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Contact).IsUnique();

            builder.Property(e=>e.Id).IsRequired()
                                     .HasColumnType("varchar")
                                     .HasMaxLength(36);

            builder.Property(e=>e.Code).IsRequired()
                                     .HasColumnType("varchar")
                                     .HasMaxLength(36);

            builder.Property(e=>e.Contact).IsRequired(false)
                                     .HasColumnType("varchar")
                                     .HasMaxLength(15);

            builder.Property(e => e.Name).IsRequired()
                                     .HasColumnType("nvarchar")
                                     .HasMaxLength(50);

            builder.Property(e => e.CustomerTypeCode).IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

            builder.Property(e=>e.EarningPoint).IsRequired(false)
                                     .HasColumnType("int");

            builder.Property(e=>e.EarningAmount).IsRequired(false)
                                     .HasColumnType("decimal(10,2)");

            builder.Property(e => e.Address).IsRequired(false)
                                     .HasColumnType("varchar").HasMaxLength(255);

            builder.Property(e => e.Email).IsRequired(false)
                                     .HasColumnType("varchar").HasMaxLength(36);

            /* builder.Property(e => e.Gender).IsRequired()
                                     .HasColumnType("int")
                                     .HasConversion<int>();*/

            /*builder.Property(e => e.Nationality).IsRequired()
                                    .HasColumnType("int")
                                    .HasConversion<int>();*/

            builder.Property(e => e.Gender).IsRequired(false)
                                   .HasColumnType("varchar")
                                   .HasMaxLength(10);

            builder.Property(e => e.Nationality).IsRequired(false)
                                   .HasColumnType("varchar")
                                   .HasMaxLength(20);

            builder.Property(e => e.CompanyId).IsRequired(false)
                                     .HasColumnType("varchar")
                                     .HasMaxLength(36);

            builder.Property(e => e.CreatedAt).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            builder.Property(e => e.IsDeleted).IsRequired().HasColumnType("bit");
            //
        }
    }
}
