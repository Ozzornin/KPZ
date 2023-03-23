using AbstractFactory.Clothes.ForChildren;
using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class ChildrenClothesFactory : IFactory
    {
        public IHat CreateHat()
        {
            return new ChildHat();
        }

        public IShoes CreateShoes()
        {
            return new ChildShoes();
        }

        public ITShirt CreateTshirt()
        {
            return new ChildTShirt();
        }
    }
}
