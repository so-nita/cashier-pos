using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class SubCategory : IEntityTypeConfiguration<Models.EntityModel.SubCategory>
    {
        public void Configure(EntityTypeBuilder<Models.EntityModel.SubCategory> builder)
        {
            builder.HasKey(e => e.Id);
            //--builder.HasIndex(e => e.Name).IsUnique();

            builder.Property(e => e.Id)
                   .IsRequired()
                   .HasColumnType("varchar") 
                   .HasMaxLength(36);

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(e => e.Image)
                   .IsRequired(false)
                   .HasColumnType("varchar")
                   .HasMaxLength(550);

            builder.Property(e => e.Main_Category_Id)
                   .IsRequired(false)
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.Company_Id)
                   .IsRequired(false)
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.Description)
                   .IsRequired(false)
                   .HasColumnType("varchar")
                   .HasMaxLength(255);

            builder.Property(e => e.Create_At)
                   .IsRequired(false)
                   .HasColumnType("datetime");

            builder.Property(e => e.UpdatedAt)
                   .IsRequired(false)
                   .HasColumnType("datetime");

            builder.Property(e => e.Status)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(20);
            //.HasConversion<int>();

            builder.Property(e => e.Is_Deleted)
                   .IsRequired(false)
                   .HasColumnType("bit");

            builder.HasOne(e=>e.Category)
                   .WithMany(e=>e.SubCategories)
                   .HasForeignKey(x => x.Main_Category_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
