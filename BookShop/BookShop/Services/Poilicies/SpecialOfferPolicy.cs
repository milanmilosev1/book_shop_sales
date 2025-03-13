using BookShop.Models.Orders;

namespace BookShop.Services.Poilicies
{
    public class SpecialOfferPolicy : IPolicy
    {
        public SpecialOfferPolicy()
        {
        }
        public void ApplyPolicy(Order order)
        {
            Console.WriteLine("Special offer");
            order.OrderPrice = CalculateTotalPriceAfterPolicy(order);
        }

        private double? CalculateTotalPriceAfterPolicy(Order order)
        {
            int totalFreeBooks = order.Books.Count / 3;
            double? totalPrice = order.Books.OrderByDescending(x => x.BasePrice).Take(order.Books.Count - totalFreeBooks).Sum(x => x.BasePrice);
            return totalPrice;
        }

    }
}
