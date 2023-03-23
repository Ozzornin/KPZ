using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForWoman
{
    public class WomanTShirt : ITShirt
    {
        public string Name => "Woman`s TShirt";

        public ClothType type => ClothType.woman;
    }
}
