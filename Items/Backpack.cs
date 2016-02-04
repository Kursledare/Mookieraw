using Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items 
{
     public class Backpack : AdventureGear, IAdventureGear
    {
        public string Name => "Backpack";

         public double Weight => 2;
    }
}
