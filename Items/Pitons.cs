﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Pitons : ClimberKit, IAdventureGear

    {
        public string Name => "Pitons";

        public double Weight => 0.5;
    }
}
