using BookShop.Models.Customers;

namespace BookShop.Services.PointsService
{
    public interface IPointsManager
    {
        public void AddPoints(Customer customer, int booksPurchased);

        public void DecreasePoints(Customer customer, int pointsToBeDecreased);
        
    }
}
