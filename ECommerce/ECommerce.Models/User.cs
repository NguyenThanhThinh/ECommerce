﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
	public class User : IdentityUser<Guid>
	{
		public List<Order> Orders { get; set; } = new List<Order>();
	}
}
