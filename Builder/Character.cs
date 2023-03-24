using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }             

        public override string ToString()
        {
            return $"Name: {Name}\nGender: {Gender}\nAge: {Age}\nHeight: {Height}cm\n" +
                   $"Hair color: {HairColor}\nEye color: {EyeColor}\nClothing: {Clothing}\n";
        }

    }
}
