using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.hero
{
    public class Warrior : Hero
    {
        public override int Attack()
        {
            return 10;
        }

        public override int Defense()
        {
            return 5;
        }
    }
}
