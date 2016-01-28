using Dices;

namespace Items.Weapons
{
    class ShortBow : Weapon
    {
        public ShortBow()
        {
            Name = "ShortBow";
			Dice = new Dice(8);
            Range = 30;
            Enchanment = 0;
            DamageType = "Stab";
            WeaponType = WeaponTypeEnum.Bow;
        }
    }
}
