using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class VirusChild : ICloneable
    {
        public DateTime BirthDate { get; set; }
        public Virus Parent { get; set; }

      
        public VirusChild(DateTime birthDate, Virus parent)
        {
            BirthDate = birthDate;
            Parent = parent;
        }

       
        public object Clone()
        {
            
            VirusChild clonedChild = (VirusChild)this.MemberwiseClone();

            clonedChild.Parent = null;

            return clonedChild;
        }
    }
}
