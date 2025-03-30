namespace PieShop.Models.Repositories.Interfaces
{
    public interface IShoppingCart
    {
        void AddToCart(Pie pie);
        int RemoveFromCart(Pie pie);
        List<ShoppingCartItem> GetAll();
        void ClearCart();
        decimal GetTotalPrice();
        List<ShoppingCartItem> shoppingCartItems { get; set; }
    }
}
