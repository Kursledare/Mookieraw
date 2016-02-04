using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Slingbullets : Ammmunition, IAdventureGear

    {
        public string Name => "Slingbullets";

        public double Weight => 0.5;
    }
}
