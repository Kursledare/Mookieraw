using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    class StandardAdventureKit : AdventureGear, IAdventureGear

    {
        public string Name => "Standard adventure kit";

        public double Weight => 33;
    }
}
