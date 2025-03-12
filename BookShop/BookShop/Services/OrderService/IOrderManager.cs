using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;

namespace BookShop.Services.OrderManager.OrderManager
{
    public interface IOrderManager
    {
        public void ProcessOrder(Customer customer, Book book, DateTime orderDate);
    }
}
