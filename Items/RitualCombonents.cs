using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class RitualCombonents : RestItems, IAdventureGear

    {
        public string Name => "Ritualcomponents";

        public double Weight => 0;
    }
}
