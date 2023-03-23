using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForWoman
{
    public class WomanShoes : IShoes
    {
        public string Name => "Woman`s shoes";

        public ClothType type => ClothType.woman;
    }
}
