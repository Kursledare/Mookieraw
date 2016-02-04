using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class FlintAndSteel : AdventureGear, IAdventureGear

    {
        public string Name => "Flina and steel";

        public double Weight => 0;
    }
}
