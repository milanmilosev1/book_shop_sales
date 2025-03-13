using BookShop.Models.Orders;
using System.Text.Json;

namespace BookShop.Services.Formatters
{
    public class JsonFormatter : IFormatter
    {
        public string Format(Order order)
        { 
            return JsonSerializer.Serialize(order); //pogledaj serialize overload za formatiranje
        }
    }
}
