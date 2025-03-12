using BookShop.Models.Orders;
using BookShop.Services.PointsService;

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
            MakeBooksFree(order);
        }

        private void MakeBooksFree(Order order)
        {
            PointsManager pointsManager = new PointsManager();
            for (int i = 0; i < order.Books.Count; i++)
            {
                if(i % 3 == 0 && i > 0)
                {
                    var book = order.Books.Where(x => x.BasePrice > 0).OrderBy(x => x.BasePrice).FirstOrDefault();            

                    if (book != null)
                    {
                        order.OrderPrice -= book.BasePrice;
                        pointsManager.DecreasePoints(order.Customer, 1);
                    }
                }
            }
        }
    }
}
