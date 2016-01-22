using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Enums;
using Items.Interfaces;

namespace Items.Shields
{
    public class WoodenShield : Shield
    {
        public WoodenShield()
        {
            base.Name = "Wooden Shield";
            base.ArmorType = ArmorTypes.Light;
            base.ArmorValue = 1;
        }
    }
}
