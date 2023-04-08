using Decorator.hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Artifact : Inventory
    {
        private int _weaponDamage;
        private int _clothDefence;
        public Artifact(Hero hero, int weaponDamage, int clothDefence) : base(hero)
        {
            _weaponDamage = weaponDamage;
            _clothDefence = clothDefence;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Damage + " +  _weaponDamage + 
                "\nDefence + "+ _clothDefence);
            Console.ResetColor();
        }

        public override int Attack()
        {
            return hero.Attack() + _weaponDamage;
        }

        public override int Defense()
        {
            return hero.Defense() + _clothDefence;
        }
    }
}
