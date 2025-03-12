using BookShop.Models.Orders;

namespace BookShop.Services.Poilicies
{
    public class RegularOfferPolicy : IPolicy
    {
        public void ApplyPolicy(Order order)
        {
            order.OrderPrice *= 1.5;
        }
    }
}
