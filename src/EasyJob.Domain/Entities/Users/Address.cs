namespace EasyJob.Domain.Entities.Users;

public sealed class Address
{
    public Guid Id { get; set; }
    public string Country { get; set; }
    public string? Region { get; set; }
    public string? Street { get; set; }
    public short? PostalCode { get; set; }
}