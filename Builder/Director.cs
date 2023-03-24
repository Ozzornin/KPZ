using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public ICharacterBuilder builder { get; set; }
        public void ConstructCharacher()
        {
            builder.BuildName();
            builder.BuildHeight();
            builder.BuildClothing();
            builder.BuildAge();
            builder.BuildGender();
            builder.BuildEyeColor();
            builder.BuildHairColor();
        }       
    }
}
