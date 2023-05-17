using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF.ConcreteHandlers
{
    public class FourthHandler : MainHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 4)
            {
               return base.Handle(arg);
            }

            return "Ordering a new connection logic";
        }
    }
}
