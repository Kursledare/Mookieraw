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
            if (Shield != null) return  Armor.Select(x => x.ArmorValue).Sum() + Shield.ArmorValue;

            return Armor.Select(x => x.ArmorValue).Sum();
        }

        public int GetEquipmentAttackBonus()
        {
            return Weapons.Select(x => x.Enchanment).Sum();

        }

        public Equipment()
        {
            Weapons=new List<IWeapon>();
            Armor=new List<IArmor>();
        }
    }
}