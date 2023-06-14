using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public abstract class ArmorClass
    {
        public abstract int Defense { get; }
        public abstract int Durability { get; }
    }
}
