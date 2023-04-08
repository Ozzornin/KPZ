using Decorator.hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Weapon : Inventory
    {
        private int _weaponDamage;
        public Weapon(Hero hero, int weaponDamage) : base(hero)
        {
            _weaponDamage = weaponDamage;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Damage +" + weaponDamage);
            Console.ResetColor();
        }

        public override int Attack()
        {
            return hero.Attack() + _weaponDamage;
        }

        public override int Defense()
        {
            return hero.Defense() + 1;
        }       
    }

}
