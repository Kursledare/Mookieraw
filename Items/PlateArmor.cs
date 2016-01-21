using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipment
{
    class PlateArmor : Armor, IItems
    { 
        private string armorType;
        public int Armorvalue { get; } = 6;

        public string ArmorType
        {
            get { return "Plate armor"; }
        }
        public string Name
        {
            get { return "The battlearmor"; }
        }
    }
}
