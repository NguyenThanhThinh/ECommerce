using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Implementations
{
	public class CategoryService : ICategoryService
	{
		private readonly ECommerceDbContext _db;

		public CategoryService(ECommerceDbContext db)
		{
			this._db = db;
		}

		public async Task<IEnumerable<Category>> AllAsync()
		{
			return await _db.Categories.OrderBy(n => n.Name).ToListAsync();
		}

		public async Task<Category> ByIdAsync(int categoryId)
		{
			return await _db.Categories.FirstOrDefaultAsync(n => n.Id == categoryId);
		}

		public async Task<Category> ByNameAsync(string categoryName)
		{
			return await _db.Categories.FirstOrDefaultAsync(n => n.Name.ToLower() == categoryName.ToLower());
		}
	}
}
