using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Enums;

namespace GameEquipment
{
   public class LeatherArmor : Armor, IItems
   {
       public LeatherArmor()
       {
            base.Name = "Leather Armor";
            base.ArmorType = ArmorTypes.Light;
            base.ArmorValue = 2;
       }
    }
}
