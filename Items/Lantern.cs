﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Lantern : RestItems, IAdventureGear

    {
        public string Name => "Lantern";
        

        public double Weight => 2;
    }
}
