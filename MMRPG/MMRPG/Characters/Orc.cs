using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class Orc : Race
    {
        public override string Name { get; }

        public Orc(string name)
        {
            Name = name;
        }
    }
}
