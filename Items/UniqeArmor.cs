using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipment
{
    class UniqeArmor : Armor, IItems
    {
        private string armorType;
        public int Armorvalue { get; } = 10;

        public string ArmorType
        {
            get { return "UniqeArmor"; }
        }
        public string Name
        {
            get { return "The Armor of the Doom"; }
        }
    }
}