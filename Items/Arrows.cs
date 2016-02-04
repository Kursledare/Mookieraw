using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Arrows : Ammmunition, IAdventureGear
    {
        public string Name => "Arrows";

        public double Weight => 0.3;
    }
}
