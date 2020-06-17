using ECommerce.Data.Configurations;
using ECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerce.Data
{
	public class ECommerceDbContext : IdentityDbContext<User, Role, Guid>
	{
		public ECommerceDbContext(DbContextOptions options) : base(options)
		{
		}

		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new OrderConfiguration());
			modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
			modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
			modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
			modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

			modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
			modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
			modelBuilder.Ignore<IdentityUserLogin<string>>();
			

		}
		public DbSet<Product> Products { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<OrderItem> OrderItems { get; set; }

		public DbSet<CartItem> CartItems { get; set; }
	}
}
