using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class ThivesTools : RestItems, IAdventureGear

    {
        public string Name => "Thives tools";

        public double Weight => 1;
    }
}
