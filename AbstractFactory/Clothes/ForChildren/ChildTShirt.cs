using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForChildren
{
    public class ChildTShirt : ITShirt
    {
        public string Name => "TShirt for children";

        public ClothType type => ClothType.child;
    }
}
