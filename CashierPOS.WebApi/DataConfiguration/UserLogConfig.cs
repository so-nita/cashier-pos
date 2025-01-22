using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CashierPOS.WebApi.DataConfiguration
{
    public class UserLogConfig : IEntityTypeConfiguration<UserLog>
    {
        public void Configure(EntityTypeBuilder<UserLog> builder)
        {
            //builder.HasKey(t => t.Id);
            //builder.HasIndex(e=>e.Pos_Id).IsUnique();

            /*builder.Property(e => e.Id)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.Pos_Id)
                   .HasColumnType("int")
                   .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/
            
            /*builder.Property(e => e.Id)
                   .HasColumnType("int")
                   .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/

            builder.Property(e => e.User_Id)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.User_Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            /*--builder.Property(e => e.User_Type)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);*/

            builder.Property(e => e.User_Role)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(e => e.Action)
                   .IsRequired()
                   .HasColumnType("int")
                   .HasConversion<int>();

            builder.Property(e => e.LoginAt).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.LogoutAt).IsRequired(false).HasColumnType("datetime");


            builder.HasOne(e => e.User)
                   .WithMany(e => e.UserLog)
                   .HasForeignKey(x => x.User_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
