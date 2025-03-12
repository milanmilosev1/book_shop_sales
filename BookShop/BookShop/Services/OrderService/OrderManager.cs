using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;
using BookShop.Services.DiscountManager;
using BookShop.Services.OrderManager.OrderManager;
using BookShop.Services.Poilicies;
using BookShop.Services.PointsService;

namespace BookShop.Services.OrderService
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPolicy _policy;
        private readonly IPointsManager _pointsManager;
        private readonly IDiscountManager _discountManager;

        public OrderManager(IOrderRepository orderRepository, IPolicy policy, IPointsManager pointsManager, IDiscountManager discountManager)
        {
            _orderRepository = orderRepository;
            _policy = policy;
            _pointsManager = pointsManager;
            _discountManager = discountManager;
        }

        public void ProcessOrder(Customer customer, Book book, DateTime orderDate)
        {
            Order order = new Order(customer, book, orderDate);
            _policy.ApplyPolicy(order);
            _pointsManager.AddPoints(customer, 1);
            _discountManager.ApplyDiscount(order);
            _orderRepository.AddOrder(order);
        }
    }
}
