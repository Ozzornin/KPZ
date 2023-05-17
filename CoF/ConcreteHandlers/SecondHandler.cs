using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF.ConcreteHandlers
{
    public class SecondHandler : MainHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 2)
            {
               return base.Handle(arg);
            }

            return "Questions about bills logic";
        }
    }
}
