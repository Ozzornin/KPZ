
using Decorator.Decorators;
using Decorator.hero;

Hero hero = new Paladin();
Console.WriteLine("Attack: " + hero.Attack());
Console.WriteLine("Defence:" + hero.Defense());


Console.WriteLine("\n____Clothes Added____");

hero = new Clothing(hero ,10);
Console.WriteLine("Attack: " + hero.Attack());
Console.WriteLine("Defence:" + hero.Defense());


Console.WriteLine("\n____Weapon Added____");

hero = new Weapon(hero, 10);
Console.WriteLine("Attack: " + hero.Attack());
Console.WriteLine("Defence:" + hero.Defense());


Console.WriteLine("\n____Artifact Added____");

hero = new Artifact(hero, +15, +1);
Console.WriteLine("Attack: " + hero.Attack());
Console.WriteLine("Defence:" + hero.Defense());