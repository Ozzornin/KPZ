using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Subscriptions
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription(int period) 
            : base("Domestic", period, new List<String> { "Domestic 1", "Domestic 2" }, 100)
        {

        }      
    }
}
