using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class OrcFactory : AbstractFactory
    {
        public override Race CreateCharacter(string name)
        {
            var human = new Human(name)
            {
                Health = 50,
                Strength = 40,
                Dexterity = 10
            };
            human.Wear(new Clothes());
            return human;
        }
    }
}
