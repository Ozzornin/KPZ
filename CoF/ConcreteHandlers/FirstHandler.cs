using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF.ConcreteHandlers
{
    public class FirstHandler : MainHandler
    {
        public override object Handle(object arg)
        {
            if((int)arg != 1)
            {
               return base.Handle(arg);
            }

            return "Support logic";
        }
    }
}
