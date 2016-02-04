using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Chain : RestItems, IAdventureGear

    {
        public string Name => "Chain";


        public double Weight => 0.2;
    }
}
