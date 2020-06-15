using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
	public class Order
	{
        public int Id { get; set; }

        public DateTime OrderedOn { get; set; }

        public string AddressLine { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
