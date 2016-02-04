using Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Bedroll : AdventureGear, IAdventureGear

    {
        public string Name => "Bedroll";

        public double Weight => 5;
    }
}
