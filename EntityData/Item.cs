using Items.Interfaces;
using System.Collections.Generic;
using Items;

namespace EntityData
{
    public class Item
    {
        // This class shall convert everything you can have in inventory to to items.

        public List<IWeapon> Weapons { get; }
        public List<IArmor> Armor { get; }
        public List<IAdventureGear> AdventureGear { get; }
        public List<ArcaneImplement> ArcaneImplement { get; }
        public List<Ammmunition> Ammmunition { get; }
    }
}
