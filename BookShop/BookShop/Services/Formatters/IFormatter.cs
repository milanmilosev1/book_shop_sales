using BookShop.Models.Orders;

namespace BookShop.Services.Formatters
{
    public interface IFormatter
    {
        public string Format(Order order);
    }
}
