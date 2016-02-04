using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class FineClothing : RestItems, IAdventureGear

    {
        public string Name => "Fine clothing";


        public double Weight => 6;
    }
}
