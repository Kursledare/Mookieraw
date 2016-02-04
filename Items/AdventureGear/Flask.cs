using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;

namespace Items
{
    public class Flask : RestItems
    {
        public string Name => "Flask";
        

        public double Weight => 1;
    }
}
