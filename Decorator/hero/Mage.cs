using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.hero
{
    public class Mage : Hero
    {
        public override int Attack()
        {
            return 15;
        }

        public override int Defense()
        {
            return 2;
        }
    }
}
