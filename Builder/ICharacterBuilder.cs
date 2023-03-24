using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        public Character character { get; set; }
        public Character GetCharacter();
        public void Reset();
        public void BuildName();
        public void BuildGender();
        public void BuildAge();
        public void BuildHeight();
        public void BuildHairColor();
        public void BuildEyeColor();
        public void BuildClothing();      
    }
}
