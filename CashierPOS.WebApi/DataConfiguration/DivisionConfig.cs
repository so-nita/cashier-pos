using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class DivisionConfig : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> builder)
        {

            builder.HasKey(e => e.Id);
            //builder.HasIndex(e => e.Code);

            builder.Property(e => e.Id).IsRequired()
                                       .HasColumnType("varchar")
                                       .HasMaxLength(36);

            builder.Property(e => e.Name).IsRequired()
                                       .HasColumnType("varchar")
                                       .HasMaxLength(100);

            builder.Property(e => e.CreatedAt).IsRequired()
                                      .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                      .HasColumnType("varchar")
                                      .HasMaxLength(36);

            builder.Property(e => e.IsDeleted).IsRequired().HasColumnType("bit");

            builder.Property(e => e.UpdatedAt).IsRequired(false).HasColumnType("datetime");

            builder.Property(e => e.CompanyId).IsRequired(false)
                                      .HasColumnType("varchar")
                                      .HasMaxLength(36);

            builder.HasOne(e=>e.Company)
                .WithMany(e=>e.Divisions)
                .HasForeignKey(e=>e.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
