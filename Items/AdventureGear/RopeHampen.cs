using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class RopeHampen : AdventureGear, IAdventureGear

    {
        public string Name => "Rope hampen";

        public double Weight => 0.2;
    }
}
