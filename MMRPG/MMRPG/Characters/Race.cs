using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public abstract class Race
    {
        public abstract string Name { get; }
        public int Health { get; }
        public int Strength { get; }
        public int Dexterity { get; }
        public ArmorClass Armor { get; private set; }

        public void Wear(ArmorClass armor)
        {
            Armor = armor;
        }
    }
}
