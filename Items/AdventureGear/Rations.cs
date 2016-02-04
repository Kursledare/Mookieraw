using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Rations : AdventureGear, IAdventureGear

    {
        public string Name => "Rations";

        public double Weight => 1;
    }
}
