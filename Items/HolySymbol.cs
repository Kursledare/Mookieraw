using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class HolySymbol : RestItems, IAdventureGear

    {
        public string Name => "Holy sympol";
        

        public double Weight => 1;
    }
}
