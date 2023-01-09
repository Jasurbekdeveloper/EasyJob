using EasyJob.Domain.Constants;
using EasyJob.Domain.Entities.Users;
using EasyJob.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyJob.Infrastructure.EntityTypeConfigurations;

public sealed class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable(TableName.Addresses);

        builder.HasKey(address => address.Id);

        builder
            .Property(address => address.Country)
            .HasMaxLength(50)
            .IsRequired(true);

        builder
            .Property(address => address.Region)
            .HasMaxLength(50)
            .IsRequired(false);
        
        builder
            .Property(address => address.Street)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(address => address.PostalCode)
            .IsRequired(false);

        builder.HasData(GenerateAddressess());
    }

    private List<Address> GenerateAddressess()
    {
        return new List<Address>
        {
            new Address
            {
                Id = Guid.Parse("bc56836e-0345-4f01-a883-47f39e32e079"),
                Country = "Uzbekistan"
            }
        };
    }
}
