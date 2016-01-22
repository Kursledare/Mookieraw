using System.Collections.Generic;
using System.Linq;
using Items.Interfaces;

namespace EntityData
{
    public class Equipment
    {
        public List<IWeapon> Weapons { get; set; }
        public List<IArmor> Armor { get; set; } 
        public IShield Shield{ get; set; }

        public int GetEquipmentArmorValue()
        {
            if (Armor != null) return  Armor.Select(x => x.ArmorValue).Sum() + Shield.ArmorValue;

            return 0;
        }
    }
}