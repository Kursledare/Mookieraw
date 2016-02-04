﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Chest : RestItems, IAdventureGear

    {
        public string Name => "Chest";


        public double Weight => 25;
    }
}
