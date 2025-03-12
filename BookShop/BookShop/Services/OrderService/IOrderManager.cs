using BookShop.Models.Books;
using BookShop.Models.Customers;

namespace BookShop.Services.OrderService
{
    public interface IOrderManager
    {
        public void ProcessOrder(Customer customer, List<Book> books, DateTime orderDate);
    }
}
