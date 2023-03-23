
using AbstractFactory;
using AbstractFactory.Factories;

Wardrobe wardrobe; 


Console.WriteLine("Hello, World!");
Console.WriteLine("Who are you?");
Console.WriteLine("1. Man");
Console.WriteLine("2. Woman");
Console.WriteLine("3. Child");

switch (Console.ReadLine())
{
    case "1":
        {
            wardrobe = new Wardrobe(new ManClothesFactory());
        }
        break;
    case "2":
        {
            wardrobe = new Wardrobe(new WomanClothesFactory());
        }
        break;
    case "3":
        {
            wardrobe = new Wardrobe(new ChildrenClothesFactory());
        }
        break;
    default:{ Console.Write("There is no other answers! Forget about it!"); return;}
}

while (true)
{
    Console.WriteLine("So what do you want to buy?");

    Console.WriteLine("1. Hat");
    Console.WriteLine("2. TShirt");
    Console.WriteLine("3. Shoes");
    switch (Console.ReadLine())
    {
        case "1":
            {
                wardrobe.BuyHat();
            }
            break;
        case "2":
            {
                wardrobe.BuyTShirt();
            }
            break;
        case "3":
            {
                wardrobe.BuyShoes();
            }
            break;
        default: { Console.Write("Sorry, but we dont have any other factories in our town :<"); return; }
    }   
}