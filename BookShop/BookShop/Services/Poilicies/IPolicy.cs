using BookShop.Models.Orders;

namespace BookShop.Services.Poilicies
{
    public interface IPolicy
    {
        public void ApplyPolicy(Order order);
    }
}
