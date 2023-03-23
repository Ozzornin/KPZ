using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothInterfaces
{
    public interface ITShirt
    {
        public string Name { get; }
        ClothType type { get; }
    }
}
