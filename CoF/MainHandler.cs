using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoF
{
    public abstract class MainHandler : IHandler
    {
        private MainHandler _next { get; set; }

        public virtual object Handle(object arg)
        {
            if (_next != null)
            {
                return _next.Handle(arg);
            }
            else
            {
                return "Wrong number...";
            }
            return null;
        }

        public MainHandler SetNext(MainHandler next)
        {
            _next = next;
            return next;
        }

        public MainHandler ResetNext()
        {
            var next = _next;
            _next = null;
            return next;
        }
    }
}
