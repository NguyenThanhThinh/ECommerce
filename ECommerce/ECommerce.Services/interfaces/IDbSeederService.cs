using Microsoft.AspNetCore.Builder;

namespace ECommerce.Services.interfaces
{
	public interface IDbSeederService
    {
        void SeedData(IApplicationBuilder applicationBuilder);
    }
}
