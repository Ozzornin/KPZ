using AbstractFactory.ClothInterfaces;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Wardrobe
    {
        private IFactory _factory { get; set; }
        private List<IHat> _hats= new List<IHat>();
        private List<IShoes> _shoes = new List<IShoes>();
        private List<ITShirt> _tshirts = new List<ITShirt>();

        public Wardrobe (IFactory factory)
        {
            _factory = factory;
        }

        public void BuyHat()
        {
            _hats.Add(_factory.CreateHat());
            Console.WriteLine("You have bought a " + _hats[0].Name);
            Console.WriteLine("Count of hats in your wardrobe: " + _hats.Count);
        }

        public void BuyShoes()
        {
            _shoes.Add(_factory.CreateShoes());
            Console.WriteLine("You have bought a " + _shoes[0].Name);
            Console.WriteLine("Count of shoes in your wardrobe: " + _shoes.Count);
        }

        public void BuyTShirt()
        {
            _tshirts.Add(_factory.CreateTshirt());
            Console.WriteLine("You have bought a " + _tshirts[0].Name);
            Console.WriteLine("Count of TShirts in your wardrobe: " + _tshirts.Count);
        }
    }
}
