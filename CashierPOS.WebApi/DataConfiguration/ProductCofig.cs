using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.DataConfiguration;

public class ProductCofig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Code).IsUnique();

        builder.Property(e => e.Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

        builder.Property(e => e.Code).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

        builder.Property(e => e.Name).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(100);

        builder.Property(e => e.NameKh).IsRequired(false)
                                    .HasColumnType("nvarchar")
                                    .IsUnicode(true)
                                    .HasMaxLength(255);

        builder.Property(e => e.Create_By).IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

        builder.Property(e => e.Company_Id).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

        builder.Property(e => e.Category_Id)
                                    .IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(36);

        builder.Property(e => e.Brand).IsRequired(false)
                                   .HasColumnType("varchar")
                                   .HasMaxLength(100);

        builder.Property(e => e.Image).IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(550);

        builder.Property(e => e.Cost).IsRequired()
                                    .HasColumnType("decimal(8,2)");

        builder.Property(e => e.Price).IsRequired()
                                    .HasColumnType("decimal(8,2)");

        builder.Property(e => e.Size).IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(255);

        builder.Property(e => e.Description).IsRequired(false)
                                    .HasColumnType("varchar")
                                    .HasMaxLength(255);
        
        builder.Property(e => e.ExpiredDate).IsRequired(false)
                                   .HasColumnType("datetime");

        builder.Property(e => e.Create_At).IsRequired()
                                    .HasColumnType("datetime");

        builder.Property(e => e.Updated_At).IsRequired(false)
                                    .HasColumnType("datetime");

        builder.Property(e => e.Status).IsRequired()
                                    .HasColumnType("varchar")
                                    .HasMaxLength(20);
                                    /*.HasColumnType("int")
                                    .HasConversion<int>();*/

        builder.Property(e => e.Tax).IsRequired()
                                    .HasColumnType("int")
                                    .HasConversion<int>();

        builder.Property(e => e.Is_Deleted).IsRequired(false).HasColumnType("bit");

        builder.HasOne(e => e.SubCategory)
               .WithMany(e => e.Products)
               .HasForeignKey(x => x.Category_Id)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(e => e.User)
               .WithMany(e => e.Products)
               .HasForeignKey(x => x.Create_By)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(e => e.Company)
              .WithMany(e => e.Products)
              .HasForeignKey(x => x.Company_Id)
              .OnDelete(DeleteBehavior.NoAction);

        /*builder.HasOne(e => e.Brand)
              .WithMany(e => e.Products)
              .HasForeignKey(x => x.Brand_Code)
              .OnDelete(DeleteBehavior.NoAction);*/
    }
}