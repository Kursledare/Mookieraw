﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Spellbook : RestItems, IAdventureGear

    {
        public string Name => "Spellbook";

        public double Weight => 3;
    }
}
