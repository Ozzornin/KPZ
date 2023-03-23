using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForMan
{
    public class ManShoes : IShoes
    {
        public string Name => "Man`s shoes";

        public ClothType type => ClothType.man;
    }
}
