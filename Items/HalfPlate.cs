using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Enums;

namespace GameEquipment
{
    class HalfPlate : Armor, IItems
    {
        public HalfPlate()
        {
            base.Name = "Half Plate";
            base.ArmorType = ArmorTypes.Heavy;
            base.ArmorValue = 8;
        }
    }
}
