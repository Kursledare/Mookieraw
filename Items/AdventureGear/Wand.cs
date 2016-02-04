using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Wand : ArcaneImplement, IAdventureGear
    {
        public string Name => "Wand";

        public double Weight => 0;
    }
}
