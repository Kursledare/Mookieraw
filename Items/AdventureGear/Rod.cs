using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Rod : ArcaneImplement, IAdventureGear

    {
        public string Name => "Rod";

        public double Weight => 2;
    }
}
