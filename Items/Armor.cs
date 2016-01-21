using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipment
{
    public class Armor  : IItems
    {
        private string name;
        private  int  armorvalue;
        private string armortype;

        public string armorType;

        public string ArmorType
        {
            get { return armorType; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int ArmorValue
        {
            get
            {
                return armorvalue;
            }
        }

    }
}
