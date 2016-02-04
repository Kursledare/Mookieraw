using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Torch : RestItems, IAdventureGear

    {
        public string Name => "Torch";

        public double Weight => 1;
    }
}
