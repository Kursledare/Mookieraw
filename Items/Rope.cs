using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Rope : RestItems, IAdventureGear

    {
        public string Name => "Rope, Silk";

        public double Weight => 1;
    }
}
