using AbstractFactory.ClothInterfaces;
using AbstractFactory.Clothes.ForMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ManClothesFactory : IFactory
    {
        public IHat CreateHat()
        {
            return new ManHat();
        }

        public IShoes CreateShoes()
        {
            return new ManShoes();    
        }

        public ITShirt CreateTshirt()
        {
            return new ManTShirt();
        }
    }
}
