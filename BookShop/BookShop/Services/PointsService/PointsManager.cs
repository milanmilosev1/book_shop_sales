using BookShop.Models.Customers;

namespace BookShop.Services.PointsService
{
    // extension metode
    public static class PointsManager
    {
        public static void AddPoints(this Customer customer, int points)
        {
            customer.Points += points;
        }

        public static void DecreasePoints(this Customer customer, int points)
        {
            customer.Points -= points;
        }

    }
}
