using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Enums;

namespace GameEquipment
{
    public class FullPlate : Armor, IItems
    {
        public FullPlate()
        {
            base.Name = "Full Plate";
            base.ArmorType = ArmorTypes.Heavy;
            base.ArmorValue = 9;
        }
    }
}
