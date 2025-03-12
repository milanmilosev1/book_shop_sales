using BookShop.Models.Books;
using BookShop.Models.Orders;

namespace BookShop.Services.Poilicies
{
    public class SpecialOfferPolicy : IPolicy
    {
        public SpecialOfferPolicy()
        {
        }
        public void ApplyPolicy(Order order)
        {
            //refactor
            Console.WriteLine("Special offer");
            //List<Book> thirdBooks = [.. order.Books.Where((x, i) => i % 3 == 0 && i > 0)];
            //Console.WriteLine($"free books count{thirdBooks.Count}");
        }

        private void MakeBooksFree(Order order)
        {
            int booksCount = 0;
            foreach(var book in order.Books)
            {
                if(booksCount == 2)
                {
                    order.Books.OrderBy(x => x.BasePrice).Where(x => x.BasePrice > 0).FirstOrDefault().BasePrice = 0;
                    booksCount = 0;
                }
                booksCount++;
            }
        }
    }
}
