using BookShop.Models.Books;

namespace BookShop.Models.Orders
{
    public class OrderItem
    {
        public Order Order = new Order();
        public Book book = new Book();
    }
}
