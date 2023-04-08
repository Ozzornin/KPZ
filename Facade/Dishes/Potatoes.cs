using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Dishes
{
    public class Potatoes
    {
        public static string Name = "Fried potatoes";
        private int _weight;

        public Potatoes(int weight) {
            _weight = weight;
        }

        public int GetWeight() => _weight;
    }
}
