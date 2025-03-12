using BookShop.Models.Orders;
using BookShop.Services.PointsService;

namespace BookShop.Services.Poilicies
{
    public class SpecialOfferPolicy : IPolicy
    {
        public void ApplyPolicy(Order order)
        {
            order.OrderPrice = 0;
        }
    }
}
