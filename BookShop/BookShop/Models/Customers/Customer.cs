namespace BookShop.Models.Customers
{
    public class Customer
    {
        public int? CustomerId { get; set; }
        public int? Points { get; set; }

        public Customer(int? customerId, int? points)
        {
            CustomerId = customerId;
            Points = points;
        }
        public Customer()
        {
        }
    }
}
