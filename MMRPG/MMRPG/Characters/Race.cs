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
        public abstract int Health { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Dexterity { get; set; }
        public abstract object Armor { get; set; }

        public void Wear(object armor) 
        {
            Armor = armor;
        }
    }
}
