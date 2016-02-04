using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Waterskin : AdventureGear, IAdventureGear

    {
        public string Name => "Waterskin";

        public double Weight => 4;
    }
}
