using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipment
{
    class ChainArmor : Armor, IItems
    {
        private string armorType;
        public int Armorvalue { get; } = 4;

        public string ArmorType
        {
            get { return "Chainmail"; }
        }
        public string Name
        {
            get { return "The soft militaty armot"; }
        }
    }
}
