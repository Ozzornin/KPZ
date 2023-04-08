using Decorator.hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public abstract class Inventory : Hero
    {
        protected Hero hero;

        public Inventory(Hero hero)
        {
            this.hero = hero;
        }

        public override int Attack()
        {
            return hero.Attack();
        }

        public override int Defense()
        {
            return hero.Defense();
        }        
    }
}
