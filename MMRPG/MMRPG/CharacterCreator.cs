using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class CharacterCreator
    {
        private Race race;
        public string Name;

        public CharacterCreator(AbstractFactory factory)
        {
            race = factory.CreateCharacter(Name);
        }

        public Race Create(string name)
        {
            race.Name = name;
            return race;
        }
    }
}
