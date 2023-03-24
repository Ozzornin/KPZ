// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

Director Director= new Director();
HeroBuilder HeroBuilder= new HeroBuilder();
EnemyBuilder EnemyBuilder= new EnemyBuilder();

Director.builder= HeroBuilder;
Director.ConstructCharacher();
Character p = Director.builder.GetCharacter();
Character p2 = Director.builder.GetCharacter();
Director.builder = EnemyBuilder;
Director.ConstructCharacher();
Character e2 = Director.builder.GetCharacter();
Director.ConstructCharacher();
Character p3 = Director.builder.GetCharacter();
Console.WriteLine();