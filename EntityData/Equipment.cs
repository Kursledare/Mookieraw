using System.Collections.Generic;
using Items.Interfaces;

namespace EntityData
{
    public class Equipment
    {
        public List<IWeapon> Weapons { get; set; } = new List<IWeapon>();
        public List<IArmor> Armor { get; set; } = new List<IArmor>();
        public List<IShield> Shields { get; set; } = new List<IShield>();
    }
}