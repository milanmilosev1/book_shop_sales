using BookShop.Models.Orders;
using BookShop.Services.DiscountManager;
using BookShop.Services.PointsService;
using BookShop.Constants;

namespace BookShop.Services.DiscountService
{
    public class DiscountManager : IDiscountManager
    {
        public void ApplyDiscount(Order order)
        {
            if(order.Customer.Points >= Constant.DISCOUNT_POINTS) // konstante
            {
                Console.WriteLine("Would you like to use your points for a 2% discount? (Y/N)");
                string input = Console.ReadLine()!;
                if (input == "Y" || input == "y")
                {
                    order.Customer.DecreasePoints(Constant.DISCOUNT_POINTS);
                    order.OrderPrice *= Constant.DISCOUNT_MULTIPLIER;
                    return;
                }
                else if(input == "N" || input == "n")
                {
                    return;
                }
                else
                {
                    throw new Exception("Invalid input");
                }
            }
            Console.WriteLine("No discount available");
        }
    }
}
