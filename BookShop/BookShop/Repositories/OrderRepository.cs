using BookShop.Models.Orders;

namespace BookShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> Orders;
        public OrderRepository(List<Order> orders)
        {
            Orders = orders;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            List<Order> returnList = new List<Order>();
            foreach(var order in Orders)
            { 
                returnList.Add(order);
            }
            return returnList;
        }
    }
}
