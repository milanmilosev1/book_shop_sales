using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;
using BookShop.Services.DiscountManager;
using BookShop.Services.OrderService;
using BookShop.Services.Poilicies;
using BookShop.Services.PointsService;

OrderRepository orderRepository = new OrderRepository(new List<Order>());
RegularOfferPolicy regularOfferPolicy = new RegularOfferPolicy();
PointsManager pointsManager = new PointsManager();
DiscountManager discountManager = new DiscountManager();
Customer customer = new Customer(1, 0);
Book book = new Book("Title", 1000);
Book book2 = new Book("Title2", 1000);
Book book3 = new Book("Title3", 1000);
DateTime parsedDate = DateTime.Parse("2025-03-11 10:30:00");

OrderManager orderManager = new OrderManager(orderRepository, regularOfferPolicy, pointsManager, discountManager);

orderManager.ProcessOrder(customer, book, parsedDate);
orderManager.ProcessOrder(customer, book2, parsedDate);
orderManager.ProcessOrder(customer, book3, parsedDate);

List<Order> orders = orderRepository.GetOrdersByCustomerId(1);

Console.WriteLine(orders.Count());
Console.WriteLine(customer.Points);