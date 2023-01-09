using EasyJob.Domain.Entities.Common;
using EasyJob.Domain.Enums;

namespace EasyJob.Domain.Entities.Users;

public sealed class User : Auditable
{
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public UserRole Role { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }

    public Guid AddressId { get; set; }
    public Address Address { get; set; }
}