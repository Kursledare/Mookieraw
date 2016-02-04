﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Hammer : ClimberKit, IAdventureGear

    {
        public string Name => "Hammer";

        public double Weight => 2;
    }
}
