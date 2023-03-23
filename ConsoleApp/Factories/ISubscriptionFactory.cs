using Factory.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public interface ISubscriptionFactory
    {
        public Subscription Subscribe();
    }
}
