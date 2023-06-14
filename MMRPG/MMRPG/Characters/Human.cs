using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public class Human : Race
    {
        public override string Name { get; }

        public Human(string name)
        {
            Name = name;
        }
    }
}
