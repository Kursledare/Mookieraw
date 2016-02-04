using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class JourneyBread : RestItems, IAdventureGear

    {
        public string Name => "Jorney bread";
        

        public double Weight => 0.1;
    }
}
