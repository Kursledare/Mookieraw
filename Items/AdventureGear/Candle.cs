using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Candle :RestItems, IAdventureGear
    {
        public string Name => "Candle";

        public double Weight => 0;
    }
}
