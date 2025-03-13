using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;
using BookShop.Services.DiscountService;
using BookShop.Services.Formatters;
using BookShop.Services.OrderService;

OrderRepository orderRepository = new([]);
DiscountManager discountManager = new();
JsonFormatter jsonFormatter = new();
PlainTextFormatter plainTextFormatter = new();

Customer customer = new Customer(1, 0);
Book book = new Book("Title", 1000);
Book book2 = new Book("Title2", 1000);
Book book3 = new Book("Title3", 1000);
Book book4 = new Book("Title4", 1000);
Book book5 = new Book("Title5", 1000);
Book book6 = new Book("Title6", 1000);
Book book7 = new Book("Title7", 1000);
DateTime parsedDate = DateTime.Parse("2025-03-30 10:30:00");

List<Book> books = [book, book2, book3, book4, book5, book6, book7];

OrderManager orderManager = new(orderRepository, discountManager, plainTextFormatter);
OrderManager orderManager1 = new(orderRepository, discountManager, jsonFormatter);

Order order = orderManager.ProcessOrder(customer, books, parsedDate);

orderManager.PrintOrder(order);
orderManager1.PrintOrder(order);