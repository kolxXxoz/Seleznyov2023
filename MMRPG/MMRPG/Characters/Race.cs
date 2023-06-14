using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public abstract class Race
    {
        public abstract string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public ArmorClass Armor { get; private set; }

        public void Wear(ArmorClass armor)
        {
            Armor = armor;
        }
    }
}
