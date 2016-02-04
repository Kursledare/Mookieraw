using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class RitualBook : RestItems, IAdventureGear

    {
        public string Name => "Ritual book";
        

        public double Weight => 3;
    }
}
