using BookShop.Constants;
using BookShop.Models.Orders;

namespace BookShop.Services.Poilicies
{
    public class RegularOfferPolicy : IPolicy
    {
        public void ApplyPolicy(Order order)
        {
            Console.WriteLine("Regular offer");
            order.OrderPrice *= Constant.REGULAR_POLICY_MULTIPLIER;
        }
    }
}
