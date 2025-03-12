namespace BookShop.Services.Poilicies
{
    public class PolicyFactory
    {
        public static IPolicy CreatePolicy(DateTime orderDate)
        {
            int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

            if (orderDate.Day > daysInMonth - 7)
            {
                return new SpecialOfferPolicy();
            }
            return new RegularOfferPolicy();
        }
    }
}
