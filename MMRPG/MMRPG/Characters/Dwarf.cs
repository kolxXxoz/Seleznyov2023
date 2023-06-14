using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class Dwarf : Race
    {
        public override string Name { get; }

        public Dwarf(string name)
        {
            Name = name;
        }
    }
}
