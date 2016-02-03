using System.Collections.Generic;
using System.Linq;
using EntityData.Interfaces;
using Items.Interfaces;

namespace EntityData
{
    public class Equipment : IEquipment
    {
        #region Properties
        public List<IWeapon> Weapons { get; set; }
        public List<IArmor> Armor { get; set; }
        public IShield Shield { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// This method goes through every item stored under armor and adds their values together.
        /// If the entity also holds a shield, then their shield's armor vlue is added as well.
        /// </summary>
        /// <returns></returns>
        public int GetEquipmentArmorValue()
        {
            if (Shield != null) return Armor.Select(x => x.ArmorValue).Sum() + Shield.ArmorValue;

            return Armor.Select(x => x.ArmorValue).Sum();
        }

        /// <summary>
        /// This method grabs the enchantment from your equipped weapon and passes it along.
        /// This is a temporary method, as it wouldn't function properly if dual-wielding is 
        /// implemented, but for now it works.
        /// </summary>
        /// <returns></returns>
        public int GetEquipmentEnchantmentBonus()
        {
            return Weapons.Select(x => x.Enchanment).FirstOrDefault();
        }
        #endregion

        #region Constructor
        public Equipment()
        {
            Weapons = new List<IWeapon>();
            Armor = new List<IArmor>();
        } 
        #endregion
    }
}