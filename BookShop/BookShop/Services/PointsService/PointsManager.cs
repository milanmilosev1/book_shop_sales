using BookShop.Models.Customers;

namespace BookShop.Services.PointsService
{
    public class PointsManager : IPointsManager
    {
        public void AddPoints(Customer customer, int booksPurchased)
        {
            customer.Points += booksPurchased;
        }

        public int? GetPoints(Customer customer)
        {
            return customer.Points;
        }
    }
}
