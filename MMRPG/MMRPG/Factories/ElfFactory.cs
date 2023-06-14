using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class ElfFactory : AbstractFactory
    {
        public override Race CreateCharacter(string name)
        {
            var elf = new Elf(name)
            {
                Health = 20,
                Strength = 30,
                Dexterity = 50
            };
            elf.Wear(new LeatherArmor());
            return elf;
        }
    }
}
