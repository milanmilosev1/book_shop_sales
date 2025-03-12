using BookShop.Models.Books;
using BookShop.Models.Customers;

namespace BookShop.Models.Orders
{
    public class Order 
    {
        public Customer Customer { get; set; }
        public List<Book> Books { get; set; }
        public DateTime OrderDate { get; set; }
        public double? OrderPrice { get; set; } = 0;

        public Order()
        {
        }

        public Order(Customer customer, List<Book> books, DateTime orderDate)
        {
            Customer = customer;
            Books = books;
            OrderDate = orderDate;
        }
    }
}
