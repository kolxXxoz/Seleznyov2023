﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public abstract class AbstractFactory
    {
        public abstract Race CreateCharacter(string name);
    }
}
