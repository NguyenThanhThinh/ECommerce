using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
	class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
				builder.HasMany(c => c.Products)
				.WithOne(d => d.Category)
				.HasForeignKey(d => d.CategoryId);
		}
	}
}
