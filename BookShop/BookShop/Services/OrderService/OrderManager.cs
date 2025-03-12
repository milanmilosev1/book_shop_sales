using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;
using BookShop.Services.DiscountManager;
using BookShop.Services.Poilicies;
using BookShop.Services.PointsService;

namespace BookShop.Services.OrderService
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _orderRepository;
        private IPolicy _policy;
        private readonly IPointsManager _pointsManager;
        private readonly IDiscountManager _discountManager;

        public OrderManager(IOrderRepository orderRepository, IPointsManager pointsManager, IDiscountManager discountManager)
        {
            _orderRepository = orderRepository;
            _pointsManager = pointsManager;
            _discountManager = discountManager;
        }

        private void CalculateOrderPrice(Order order)
        {
            foreach(var book in order.Books)
            {
                order.OrderPrice += book.BasePrice;
            }
            _policy.ApplyPolicy(order);
            _pointsManager.AddPoints(order.Customer, order.Books.Count);
            _discountManager.ApplyDiscount(order);
        }

        public void ProcessOrder(Customer customer, List<Book> books, DateTime orderDate)
        {
            _policy = PolicyFactory.CreatePolicy(orderDate.Day);
            Order order = new(customer, books, orderDate);
            CalculateOrderPrice(order);
            _orderRepository.AddOrder(order);
            Console.WriteLine($"\nOrder processed, total price: {order.OrderPrice}\n");
        }
    }
}
