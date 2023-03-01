using FurnitureShop.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Api.Data;

public class AppDbContext:IdentityDbContext<AppUser,AppUserRole, Guid>
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<Organization> Organizations { get; set; }
	public DbSet<OrganizationUser> OrganizationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
		base.OnModelCreating(builder);
		builder.Entity<OrganizationUser>().HasKey(user => new { user.UserId, user.OrganizationId });
    }

}
