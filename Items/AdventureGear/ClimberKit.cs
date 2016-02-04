using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class ClimberKit : IAdventureGear 

    {
        public string Name => "Climber  Kit";

        public double Weight => 11;
    }
}
