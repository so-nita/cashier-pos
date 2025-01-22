using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class MenuConfig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                       .HasColumnType("varchar")
                                       .HasMaxLength(36);

            builder.Property(e => e.Name).IsRequired()
                                      .HasColumnType("varchar")
                                       .HasMaxLength(100);

            builder.Property(e => e.Image).IsRequired(false)
                                       .HasColumnType("varchar")
                                       .HasMaxLength(556);


            builder.Property(e => e.CreatedAt).IsRequired()
                                      .HasColumnType("datetime");

            builder.Property(e => e.UpdatedAt).IsRequired(false)
                                      .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                      .HasColumnType("varchar")
                                      .HasMaxLength(36);

            builder.Property(e=>e.DivisionId).IsRequired(false)
                                       .HasColumnType("varchar")
                                       .HasMaxLength(36);

            builder.Property(e => e.IsDeleted).IsRequired().HasColumnType("bit");

            builder.HasOne(e => e.Division)
                .WithMany(e => e.Menus)
                .HasForeignKey(e => e.DivisionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
