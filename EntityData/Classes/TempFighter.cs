﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityData.Interfaces;

namespace EntityData.Classes
{
    class TempLvl1Fighter : IClass
    {
        public int ClassAttackBonus
        {
            get { return 1; }
            set { }
        }
    }
}
