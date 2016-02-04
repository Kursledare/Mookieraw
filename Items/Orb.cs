using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Orb : ArcaneImplement, IAdventureGear

    {
        public string Name => "Orb";

        public double Weight => 2;
    }
}
