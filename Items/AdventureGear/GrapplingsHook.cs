using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class GrapplingsHook : ClimberKit, IAdventureGear

    {
        public string Name => "Grapplings hook";

        public double Weight => 4;
    }
}
