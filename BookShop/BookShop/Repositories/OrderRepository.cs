using BookShop.Models.Customers;
using BookShop.Models.Orders;

namespace BookShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> Orders = new List<Order>();
        public OrderRepository(List<Order> orders)
        {
            Orders = orders;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            List<Order> ordersList = new List<Order>();
            foreach(var order in Orders)
            { 
                if(order.Customer.CustomerId == customerId)
                {
                    ordersList.Add(order);
                }
            }
            return ordersList;
        }
    }
}
