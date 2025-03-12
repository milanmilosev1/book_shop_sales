using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;

namespace BookShop.Services.OrderService
{
    public interface IOrderManager
    {
        public Order ProcessOrder(Customer customer, List<Book> books, DateTime orderDate);
    }
}
