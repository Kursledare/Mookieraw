using Dices;
using Items.Interfaces;

namespace Items
{
    public abstract class Weapon : IWeapon
    {
        public int Enchanment { get; set; }

        public Dice Dice { get; protected set; }

        public int DamageRoll()
        {
            return Dice.Roll();
        }

        public bool CanOneHanded { get; set; }

        public string Name { get; protected set; }

        public int Range { get; set; }

        public string DamageType { get; set; }

        public WeaponTypeEnum WeaponType { get; set; }

        public enum WeaponTypeEnum
        {
            None,
            Mace,
            LightBlade,
            Spear,
            HeavyBlade,
            Axe,
            Crossbow,
            Sling,
            Bow,
            Flail
        }

       
    }
}
