using Decorator.hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Clothing : Inventory
    {
        private int _clothDefence;

        public Clothing(Hero hero, int clothDefence) : base(hero)
        {
            _clothDefence = clothDefence;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Defence +" + clothDefence);
            Console.ResetColor();
        }

        public override int Attack()
        {
            return hero.Attack();
        }

        public override int Defense()
        {
            return hero.Defense() + _clothDefence;
        }        
    }
}
