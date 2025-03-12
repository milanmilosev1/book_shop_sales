using BookShop.Models.Orders;
using System.Text.Json;

namespace BookShop.Services.Formatters
{
    public class JsonFormatter : IFormatter
    {
        public string Format(Order order)
        {
            string jsonString = JsonSerializer.Serialize(order);
            return jsonString;
        }
    }
}
