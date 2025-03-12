using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;
using BookShop.Services.DiscountManager;
using BookShop.Services.Formatters;
using BookShop.Services.Poilicies;
using BookShop.Services.PointsService;

namespace BookShop.Services.OrderService
{
    public class OrderManager(IOrderRepository orderRepository, IPointsManager pointsManager, IDiscountManager discountManager, IFormatter formatter) : IOrderManager
    {
        private readonly IOrderRepository _orderRepository = orderRepository;
        private IPolicy? _policy;
        private readonly IPointsManager _pointsManager = pointsManager;
        private readonly IDiscountManager _discountManager = discountManager;
        private readonly IFormatter _formatter = formatter;

        private void CalculateOrderPrice(Order order)
        {
            foreach (var book in order.Books)
            {
                order.OrderPrice += book.BasePrice;
            }
            _pointsManager.AddPoints(order.Customer, order.Books.Count);
            _discountManager.ApplyDiscount(order);
            _policy.ApplyPolicy(order);
        }

        public Order ProcessOrder(Customer customer, List<Book> books, DateTime orderDate)
        {
            _policy = PolicyFactory.CreatePolicy(orderDate);
            Order order = new(customer, books, orderDate);
            CalculateOrderPrice(order);
            _orderRepository.AddOrder(order);
            Console.WriteLine($"\nOrder processed, total price: {order.OrderPrice}\n");
            return order;
        }

        public void PrintOrder(Order order)
        {
            Console.WriteLine(_formatter.Format(order));
        }
    }
}
