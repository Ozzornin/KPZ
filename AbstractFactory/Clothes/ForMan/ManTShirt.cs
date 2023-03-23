using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForMan
{
    public class ManTShirt : ITShirt
    {
        public string Name => "Man`s TShirt";

        public ClothType type => ClothType.man;
    }
}
