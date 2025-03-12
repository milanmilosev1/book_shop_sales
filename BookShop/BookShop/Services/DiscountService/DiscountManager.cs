using BookShop.Models.Orders;

namespace BookShop.Services.DiscountManager
{
    public class DiscountManager : IDiscountManager
    {
        public void ApplyDiscount(Order order)
        {
            if(order.Customer.Points >= 5)
            {
                Console.WriteLine("Would you like to use your points for a 2% discount?");
                string input = Console.ReadLine();
                if(input == "Y")
                {
                    order.Customer.Points -= 5;
                    order.OrderPrice *= 0.98;
                    return;
                }
            }
            Console.WriteLine("No discount available");
        }
    }
}
