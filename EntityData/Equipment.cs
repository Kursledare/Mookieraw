using System.Collections.Generic;
using Items.Interfaces;

namespace EntityData
{
    public class Equipment
    {
        public List<IWeapon> Weapons { get; set; }
        public List<IArmor> Armor { get; set; } 
        public List<IShield> Shields { get; set; } 
    }
}