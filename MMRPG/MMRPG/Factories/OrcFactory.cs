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
            var orc = new Orc(name)
            {
                Health = 50,
                Strength = 40,
                Dexterity = 10
            };
            orc.Wear(new Clothes());
            return orc;
        }
    }
}
