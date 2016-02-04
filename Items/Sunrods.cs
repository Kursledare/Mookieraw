using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Sunrods : AdventureGear, IAdventureGear

    {
        public string Name => "Sunrods";

        public double Weight => 1;
    }
}
