using ECommerce.Models;
using ECommerce.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Implementations
{
	public class CategoryService : ICategoryService
	{
		public Task<IEnumerable<Category>> AllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Category> ByIdAsync(int categoryId)
		{
			throw new NotImplementedException();
		}

		public Task<Category> ByNameAsync(string categoryName)
		{
			throw new NotImplementedException();
		}
	}
}
