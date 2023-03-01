using FurnitureShop.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Api.Data;

public class AppDbContext:IdentityDbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<Organization> Organizations { get; set; }
	public DbSet<OrganizationUser> OrganizationUsers { get; set; }

}
