using BookShop.Repositories;

namespace BookShop.Services.Poilicies
{
    public class PolicyFactory
    {
        public static IPolicy CreatePolicy(int dateTime)
        {
            switch (dateTime)
            {
                case > 23:
                    return new SpecialOfferPolicy();
                case <= 23:
                    return new RegularOfferPolicy();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
