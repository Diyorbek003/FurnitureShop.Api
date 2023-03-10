namespace FurnitureShop.Api.Entities;

public class Organization
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public EOrganizationStatus Status { get; set; }
    public ICollection<OrganizationUser>? OrganizationUsers { get; set; }
}
