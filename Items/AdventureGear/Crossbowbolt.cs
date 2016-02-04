using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Crossbowbolt : Ammmunition, IAdventureGear

    {
        public string Name => "Crossbow bolt";

        public double Weight => 0.2;
    }
}
