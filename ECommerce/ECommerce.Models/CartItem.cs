namespace ECommerce.Models
{
	public class CartItem
	{
		public int Id { get; set; }

		public int ProductId { get; set; }

		public Product Product { get; set; }

		public int Amount { get; set; }

		public string ShoppingCartId { get; set; }
	}
}
