using BookShop.Models.Books;
using BookShop.Models.Customers;

namespace BookShop.Models.Orders
{
    public class Order 
    {
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? OrderPrice { get; set; } = 0;

        public Order()
        {
        }

        public Order(Customer customer, Book book, DateTime? orderDate)
        {
            Customer = customer;
            Book = book;
            OrderDate = orderDate;
        }
    }
}
