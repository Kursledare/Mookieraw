using GameEquipment;
using Items.Interfaces;
using System.Collections.Generic;
using Items;

namespace EntityData
{
    public class Item
    {
        // This class shall convert Armor and Weapons to item.

        public List<IWeapon> Weapons { get; set; }
        public List<IArmor> Armor { get; set; }

        
    }
}
