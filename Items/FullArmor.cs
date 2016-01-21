using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipment
{
    class FullArmor : Armor, IItems
    {
        private string armorType;
        public int Armorvalue { get; } = 8;

        public string ArmorType
        {
            get { return "Full armor"; }
        }
        public string Name
        {
            get { return "The battlemaster armor"; }
        }
    }
}
