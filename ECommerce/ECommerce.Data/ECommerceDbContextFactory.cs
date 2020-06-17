using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ECommerce.Data
{
	public class ECommerceDbContextFactory : IDesignTimeDbContextFactory<ECommerceDbContext>
	{


		ECommerceDbContext IDesignTimeDbContextFactory<ECommerceDbContext>.CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("ECommerceDbContext");

			var optionsBuilder = new DbContextOptionsBuilder<ECommerceDbContext>();

			optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("ECommerce.Data"));

			return new ECommerceDbContext(optionsBuilder.Options);
		}
	}
}
