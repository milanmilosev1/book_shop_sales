using BookShop.Models.Orders;
using BookShop.Services.DiscountManager;
using BookShop.Services.PointsService;

namespace BookShop.Services.DiscountService
{
    public class DiscountManager : IDiscountManager
    {
        public void ApplyDiscount(Order order)
        {
            if(order.Customer.Points >= 5)
            {
                Console.WriteLine("Would you like to use your points for a 2% discount? (Y/N)");
                string input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    PointsManager pointsManager = new PointsManager();
                    pointsManager.DecreasePoints(order.Customer, 5);
                    order.OrderPrice *= 0.98;
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
