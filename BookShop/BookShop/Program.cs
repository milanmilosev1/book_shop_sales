using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;
using BookShop.Services.DiscountManager;
using BookShop.Services.OrderService;
using BookShop.Services.Poilicies;
using BookShop.Services.PointsService;

OrderRepository orderRepository = new([]);
RegularOfferPolicy regularOfferPolicy = new();
PointsManager pointsManager = new();
DiscountManager discountManager = new();
Customer customer = new Customer(1, 0);
Customer customer2 = new Customer(2, 0);
Book book = new Book("Title", 1000);
Book book2 = new Book("Title2", 1000);
Book book3 = new Book("Title3", 1000);
DateTime parsedDate = DateTime.Parse("2025-03-30 10:30:00");

List<Book> books = [book, book2, book3, book, book, book, book];
List<Book> books2 = [book];

OrderManager orderManager = new(orderRepository, pointsManager, discountManager);

orderManager.ProcessOrder(customer, books, parsedDate);
orderManager.ProcessOrder(customer2, books2, parsedDate);

List<Order> customerOrders = new List<Order>();
customerOrders = orderRepository.GetOrdersByCustomerId(1);

Console.WriteLine($"number of orders: {customerOrders.Count}");
Console.WriteLine($"number of orders in repo: {orderRepository.GetAllOrders().Count}");
Console.WriteLine($"\nCustomer Points: {customer.Points}");
Console.WriteLine($"\nCustomer Points: {customer2.Points}");