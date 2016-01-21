using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipment
{
   public class LeatherArmor : Armor, IItems
   {
       private string armorType;


       public int Armorvalue { get; } = 2;

       public string ArmorType
       {
           get { return "Leather armor"; } 
       }

       public string Name
       {
           get { return "The monsteskin"; }
       }
    }
}
