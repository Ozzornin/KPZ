using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForChildren
{
    public class ChildHat : IHat
    {
        public string Name => "Hat for children";

        public ClothType type => ClothType.child;
    }
}
