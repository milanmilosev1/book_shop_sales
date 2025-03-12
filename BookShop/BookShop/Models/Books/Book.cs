namespace BookShop.Models.Books
{
    public class Book
    {
        public string? BookTitle { get; set; }
        public double? BasePrice { get; set; }

        public Book(string? bookTitle, double? basePrice)
        {
            BookTitle = bookTitle;
            BasePrice = basePrice;
        }
        public Book()
        {
        }
    }
}
