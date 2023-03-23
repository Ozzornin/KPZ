using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<VirusChild> Children { get; set; }

        public Virus(double weight, int age, string name, string species, List<VirusChild> children)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = children;
        }

        public object Clone()
        {           
            Virus clonedVirus = (Virus)this.MemberwiseClone();

            
            List<VirusChild> clonedChildren = new List<VirusChild>();
            foreach (VirusChild child in Children)
            {
                VirusChild clonedChild = (VirusChild)child.Clone();
                clonedChild.Parent = clonedVirus;
                clonedChildren.Add(clonedChild);
            }
            clonedVirus.Children = clonedChildren;

            return clonedVirus;
        }
    }
}
