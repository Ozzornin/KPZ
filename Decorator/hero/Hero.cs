using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.hero
{
    public abstract class Hero
    {
        public string Name { get; set; }

        public abstract int Attack();
        public abstract int Defense();
    }
}
