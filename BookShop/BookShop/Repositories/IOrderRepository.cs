using BookShop.Models.Orders;

namespace BookShop.Repositories
{
    public interface IOrderRepository
    {
        public void AddOrder(Order order);
        public List<Order> GetAllOrders();
    }
}
