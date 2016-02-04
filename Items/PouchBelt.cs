using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class PouchBelt : AdventureGear, IAdventureGear

    {
        public string Name => "Pouch belt";

        public double Weight => 0.5;
    }
}
