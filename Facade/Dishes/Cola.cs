using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Dishes
{
    public class Cola
    {
        public const string Name = "CocaCola";
        private int _volume;
        public Cola(int volume) { 
            _volume = volume;
        }

        public int GetVolume()=> _volume;
        
    }
}
