using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class DwarfFactory : AbstractFactory
    {
        public override Race CreateCharacter(string name)
        {
            var dwarf = new Dwarf(name)
            {
                Health = 40,
                Strength = 40,
                Dexterity = 20
            };
            dwarf.Wear(new ChainArmor());
            return dwarf;
        }
    }
}
