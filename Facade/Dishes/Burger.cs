using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Dishes
{
    public class Burger
    {
        public string Name { get; set; }
        private int _weight;

        public Burger(string name, int weight) {
            Name = name;
            _weight = weight;
        }
    }
}
