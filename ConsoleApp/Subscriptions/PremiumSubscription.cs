using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Subscriptions
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(int period)
            : base("Premium", period, new List<String> { "Premium 1", "Premium 2"}, 150)
        {

        }
    }
}
