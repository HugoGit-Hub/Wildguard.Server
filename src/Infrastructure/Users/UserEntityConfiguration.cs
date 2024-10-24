using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Users;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(64);
        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(64);
        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(64);
        builder.HasIndex(x => x.Email)
            .IsUnique();
        builder.Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(256);
        builder.Property(x => x.Role)
            .IsRequired();
    }
}