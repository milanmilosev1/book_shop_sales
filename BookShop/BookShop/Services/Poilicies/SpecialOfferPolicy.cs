using BookShop.Models.Books;
using BookShop.Models.Customers;
using BookShop.Models.Orders;
using BookShop.Repositories;

namespace BookShop.Services.Poilicies
{
    public class SpecialOfferPolicy : IPolicy
    {
        private readonly IOrderRepository _orderRepository;

        public SpecialOfferPolicy()
        {
        }

        public SpecialOfferPolicy(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void ApplyPolicy(Order order)
        {
            Console.WriteLine("Special offer\n");
            int lastBook = order.Books.Count - 1;
            List<Book> thirdBooks = order.Books.Where((x, i) => i % 3 == 0 && i > 0).ToList();
            Console.WriteLine(thirdBooks.Count);
            if(thirdBooks != null && thirdBooks.Count > 0)
            {
                foreach (var book in thirdBooks)
                {
                    order.OrderPrice -= book.BasePrice;
                    order.Customer.Points--;
                }
                
            }
        }
    }
}
