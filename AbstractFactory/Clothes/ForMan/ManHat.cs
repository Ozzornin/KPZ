using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForMan
{
    public class ManHat : IHat
    {
        public string Name => "Man`s hat";

        public ClothType type => ClothType.man;
    }
}
