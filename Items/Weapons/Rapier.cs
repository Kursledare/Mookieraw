using Dices;

namespace Items.Weapons
{
    class Rapier : Weapon
    {
        public Rapier()
        {
            Name = "Rapier";
			Dice = new Dice(8);
            Range = 1;
            Enchanment = 0;
            DamageType = "Stab";
            WeaponType = WeaponTypeEnum.LightBlade;
        }
    }
}
