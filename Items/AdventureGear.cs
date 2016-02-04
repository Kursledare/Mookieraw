using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class AdventureGear : IAdventureGear
    {
        public string Name { get; }
        

        public double Weight { get; }
    }
}
