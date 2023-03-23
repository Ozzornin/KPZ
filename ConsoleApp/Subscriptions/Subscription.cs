using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Subscriptions
{
    public class Subscription
    {
        private string _name {get;}
        private int _period { get; } = 10;
        private List<string> _channels = new List<string>();
        private int _monthlyFee { get; }

        public Subscription(string name, int period, List<string> channels, int monthlyFee)
        {
            _name = name;
            if (period < this._period)
            {
                period = this._period;
            }
            this._period = period;
            this._channels = channels;
            this._monthlyFee = monthlyFee;
        }

        public string GetInfo()
        {
            string info = "";
            info += "\nYour current subscription is " + _name;
            info += "\nAvailable channels: " + String.Join(", ", _channels.ToArray());
            info += "\nMonthly fee is $" + _monthlyFee;
            return info;
        }
    }
}
