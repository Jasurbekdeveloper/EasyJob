using EasyJob.Domain.Constants;
using EasyJob.Domain.Entities.Users;
using EasyJob.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyJob.Infrastructure.EntityTypeConfigurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(TableName.Users);

        builder.HasKey(user => user.Id);

        builder
            .Property(user => user.FirstName)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(user => user.LastName)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(user => user.PhoneNumber)
            .HasMaxLength(30)
            .IsRequired(true);

        builder
            .Property(user => user.Email)
            .HasMaxLength(255)
            .IsRequired(true);

        builder
            .Property(user => user.PasswordHash)
            .HasMaxLength(256)
            .IsRequired(true);

        builder
            .Property(user => user.Salt)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(user => user.CreatedAt)
            .IsRequired(true);

        builder
            .HasOne(user => user.Address)
            .WithOne()
            .HasForeignKey<User>(user => user.AddressId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(GenerateUsers());
    }

    private List<User> GenerateUsers()
    {
        return new List<User>
        {
            new User
            {
                Id = Guid.Parse("bc56836e-0345-4f01-a883-47f39e32e079"),
                FirstName = "Toxirjon",
                Role = UserRole.Admin,
                PhoneNumber = "931234567",
                Email = "toxirjon@gmail.com",
                PasswordHash = "12345",
                Salt = Guid.NewGuid().ToString(),
                AddressId = Guid.Parse("bc56836e-0345-4f01-a883-47f39e32e079")
            }
        };
    }
}
