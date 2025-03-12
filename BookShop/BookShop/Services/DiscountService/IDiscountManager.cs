using BookShop.Models.Orders;

namespace BookShop.Services.DiscountManager
{
    public interface IDiscountManager
    {
        public void ApplyDiscount(Order order);
    }
}
