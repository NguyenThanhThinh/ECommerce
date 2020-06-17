using ECommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Services.interfaces
{
	public interface ICategoryService
    {
        Task<IEnumerable<Category>> AllAsync();

        Task<Category> ByNameAsync(string categoryName);

        Task<Category> ByIdAsync(int categoryId);
    }
}
