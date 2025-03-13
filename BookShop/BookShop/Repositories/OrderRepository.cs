using BookShop.Models.Orders;

namespace BookShop.Repositories
{
    public class OrderRepository(List<Order> orders) : IOrderRepository
    {
        public List<Order> Orders = orders;

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return Orders;
        }
    }
}
