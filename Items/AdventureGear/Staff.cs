using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Staff : ArcaneImplement, IAdventureGear

    {
        public string Name => "Staff";

        public double Weight => 4;
    }
}
