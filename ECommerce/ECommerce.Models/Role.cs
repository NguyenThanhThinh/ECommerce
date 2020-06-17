using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models
{
	public class Role : IdentityRole<Guid>
	{
		public string Description { get; set; }
	}
}
