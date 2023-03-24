using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        public Character character { get; set; }
        
        public Character GetCharacter()
        {
            Character c = this.character;
            Reset();
            return c;
        }

        public void Reset()
        {
            this.character = new Character();
        }

        public HeroBuilder()
        {
            this.character = new Character();
        }

        public void BuildName()
        {
            character.Name = "Hero";
        }

        public void BuildGender()
        {
            character.Gender = "Male";
        }

        public void BuildAge()
        {
            character.Age = 20;
        }

        public void BuildHeight()
        {
            character.Height = 175.6;
        }

        public void BuildHairColor()
        {
            character.HairColor = "blue";
        }

        public void BuildEyeColor()
        {
            character.EyeColor = "blue";
        }

        public void BuildClothing()
        {
            character.Clothing = "none";
        }

    }


}

