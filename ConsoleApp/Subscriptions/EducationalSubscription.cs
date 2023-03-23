using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Subscriptions
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(int period)
            : base("Educational", period, new List<String> { "Educational 1", "Educational 2" }, 75)
        {

        }
    }
}
