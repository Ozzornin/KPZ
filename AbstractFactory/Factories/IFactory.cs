using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public interface IFactory
    {
        public IShoes CreateShoes();
        public ITShirt CreateTshirt();
        public IHat CreateHat();
    }
}
