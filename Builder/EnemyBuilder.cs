using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
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

        public EnemyBuilder()
        {
            this.character = new Character();
        }

        public void BuildName()
        {
            character.Name = "Enemy";
        }

        public void BuildGender()
        {
            character.Gender = "Male";
        }

        public void BuildAge()
        {
            character.Age = 30;
        }

        public void BuildHeight()
        {
            character.Height = 180.0;
        }

        public void BuildHairColor()
        {
            character.HairColor = "black";
        }

        public void BuildEyeColor()
        {
            character.EyeColor = "blue";
        }

        public void BuildClothing()
        {
            character.Clothing = "Leather jacked, jeans";
        }        
    }
}
