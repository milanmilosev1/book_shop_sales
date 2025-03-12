using BookShop.Models.Orders;

namespace BookShop.Services.Poilicies
{
    public class RegularOfferPolicy : IPolicy
    {
        public void ApplyPolicy(Order order)
        {
            Console.WriteLine("Regular offer\n");
            order.OrderPrice *= 1.5;
        }
    }
}
