using System.Collections.Generic;

namespace ECommerce.Models
{
	public class Product
	{
        public int Id { get; set; }


        public string Name { get; set; }


        public string Description { get; set; }


        public string FullDescription { get; set; }


        public decimal Price { get; set; }

     
        public string ImageUrl { get; set; }

    
        public string ImageThumbnailUrl { get; set; }

        public bool IsPreferred { get; set; }

        public bool IsInStock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
