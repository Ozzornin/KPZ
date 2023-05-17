using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF.ConcreteHandlers
{
    public class FifthHandler : MainHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 5)
            {
               return base.Handle(arg);
            }

            return "Other logic";
        }
    }
}
