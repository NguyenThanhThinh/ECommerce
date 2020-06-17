using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			    builder
			   .HasMany(o => o.OrderItems)
			   .WithOne(p => p.Order)
			   .HasForeignKey(p => p.OrderId);
		}
	}
}
