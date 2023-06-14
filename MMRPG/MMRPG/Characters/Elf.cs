using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class Elf : Race
    {
        public override string Name { get; }

        public Elf(string name)
        {
            Name = name;
        }
    }
}
