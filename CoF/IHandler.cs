using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF
{
    internal interface IHandler
    {
        public object Handle(object arg);
        public MainHandler SetNext(MainHandler handler);
    }
}
