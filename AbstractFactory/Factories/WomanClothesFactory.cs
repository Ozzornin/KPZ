using AbstractFactory.Clothes.ForWoman;
using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class WomanClothesFactory : IFactory
    {
        public IHat CreateHat()
        {
            return new WomanHat();
        }

        public IShoes CreateShoes()
        {
            return new WomanShoes();
        }

        public ITShirt CreateTshirt()
        {
            return new WomanTShirt();
        }
    }
}
