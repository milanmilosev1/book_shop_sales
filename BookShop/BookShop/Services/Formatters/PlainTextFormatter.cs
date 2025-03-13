using BookShop.Models.Orders;
using System.Text;

namespace BookShop.Services.Formatters
{
    public class PlainTextFormatter : IFormatter
    {
        public string Format(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            var sb = new StringBuilder();
            sb.AppendLine($"Customer ID: {order.Customer.CustomerId}");
            sb.AppendLine("Books Purchased:");

            foreach (var book in order.Books)
            {
                sb.AppendLine($"  - Title: {book.BookTitle}, Base Price: {book.BasePrice}");
            }

            sb.AppendLine($"Total order price: {order.OrderPrice}");

            return sb.ToString();
        }
    }
}
