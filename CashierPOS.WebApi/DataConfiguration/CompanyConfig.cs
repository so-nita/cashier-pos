using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Code).IsRequired(false)
                                        .HasColumnType("int");

            builder.Property(e => e.Name).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);

            builder.Property(e => e.NameKh).IsRequired(false)
                                        .HasColumnType("nvarchar")
                                        .HasMaxLength(100)
                                        .IsUnicode();

            builder.Property(e => e.System_Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Email).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);

            builder.Property(e => e.Contact).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(12);

            builder.Property(e => e.Image).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(500);

            builder.Property(e => e.Website).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(255);

            builder.Property(e => e.Address).IsRequired()
                                        .HasColumnType("nvarchar")
                                        .HasMaxLength(255);

            builder.Property(e => e.Create_At).IsRequired()
                                        .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            builder.Property(e => e.Exchange_Rate).IsRequired()
                                        .HasColumnType("decimal(8,2)");

            builder.Property(e => e.SaleExchangeRate).IsRequired(false)
                                        .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Is_Deleted).IsRequired(false).HasColumnType("bit");

            builder.HasOne(e => e.SystemType)
                  .WithMany(e => e.Companies)
                  .HasForeignKey(x => x.System_Id)
                  .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
