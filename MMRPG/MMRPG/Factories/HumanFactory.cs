using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class HumanFactory : AbstractFactory
    {
        public override Race CreateCharacter(string name)
        {
            var human = new Human(name)
            {
                Health = 40,
                Strength = 30,
                Dexterity = 30
            };
            human.Wear(new SteelArmor());
            return human;
        }
    }
}
