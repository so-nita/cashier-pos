using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class SourceConfig : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

            builder.Property(x => x.Name).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(100);

            builder.Property(x => x.Desctiption).IsRequired(false)
                                    .HasColumnType("nvarchar")
                                    .HasMaxLength(255);

            builder.Property(e => e.Status).IsRequired()
                                    .HasColumnType("int")
                                    .HasConversion<int>();

            builder.Property(e => e.Create_At).IsRequired()
                                    .HasColumnType("datetime");

            builder.Property(e => e.Is_Deleted).IsRequired().HasColumnType("bit");
        }
    }
}
