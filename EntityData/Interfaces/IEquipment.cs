using System.Collections.Generic;
using Items.Interfaces;

namespace EntityData.Interfaces
{
    public interface IEquipment
    {
        List<IWeapon> Weapons { get; set; }
        List<IArmor> Armor { get; set; }
        IShield Shield { get; set; }
        int GetEquipmentArmorValue();
        int GetEquipmentEnchantmentBonus();
    }
}