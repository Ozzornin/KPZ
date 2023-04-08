using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Misc
{
    public class Price
    {

        public string Currency;
        public double Amount;

        public Price(string currency, double amount) {
            Currency = currency;
            Amount = amount;
        }

    }
}
