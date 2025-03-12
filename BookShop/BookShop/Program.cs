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
Book book = new Book("Title", 1000);
Book book2 = new Book("Title2", 1000);
Book book3 = new Book("Title3", 1000);
DateTime parsedDate = DateTime.Parse("2025-03-03 10:30:00");

List<Book> books = [book, book2, book3, book, book, book];

OrderManager orderManager = new(orderRepository, pointsManager, discountManager);

orderManager.ProcessOrder(customer, books, parsedDate);

Console.WriteLine($"number of orders: {orderRepository.Orders.Count}");
Console.WriteLine($"\nCustomer Points: {customer.Points}");