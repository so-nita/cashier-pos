using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;

namespace CashierPOS.WebApi.EntityConfiguration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    { 
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.UserName).IsUnique();

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Name).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);

            builder.Property(e => e.UserName).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(50);

            /*builder.Property(e => e.Gender).IsRequired(false)
                                        .HasColumnType("int")
                                        .HasConversion<int>();*/

            builder.Property(e => e.Gender).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(10);


            builder.Property(e => e.Email).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);

            builder.Property(e => e.Password).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);

            builder.Property(e => e.Contact).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(12);

            builder.Property(e => e.Image).IsRequired(false)
                                        .HasColumnType("varchar")
                                        .HasMaxLength(550);

            builder.Property(e => e.Company_Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            /*--builder.Property(e => e.Role_Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);*/

            builder.Property(e => e.Address).IsRequired(false)
                                        .HasColumnType("nvarchar")
                                        .HasMaxLength(550);

            builder.Property(e => e.Create_At).IsRequired()
                                        .HasColumnType("datetime");

            builder.Property(e => e.Status).IsRequired()
                                        .HasColumnType("int")
                                        .HasConversion<int>();

            builder.Property(e => e.Is_Deleted)
                                        .IsRequired()
                                        .HasColumnType("bit");

            builder.Property(e => e.Token).IsRequired(false)
                                        .HasColumnType("nvarchar")
                                        .HasMaxLength(550);

            builder.HasOne(e => e.Company)
                   .WithMany(e => e.Users)
                   .HasForeignKey(x => x.Company_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            /*--builder.HasOne(e => e.Role)
                   .WithMany(e => e.Users)
                   .HasForeignKey(x => x.Role_Id)
                   .OnDelete(DeleteBehavior.NoAction);*/
        }
    }
}
