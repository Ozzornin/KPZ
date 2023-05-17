using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF.ConcreteHandlers
{
    public class ThirdHandler : MainHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 3)
            {
               return base.Handle(arg);
            }

            return "Information about tariffs logic";
        }
    }
}
