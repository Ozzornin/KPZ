using AbstractFactory.ClothInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Clothes.ForWoman
{
    public class WomanHat : IHat
    {
        public string Name => "Woman`s hat";

        public ClothType type => ClothType.woman;
    }
}
