using Dices;

namespace Items.Weapons
{
    class Handaxe : Weapon
    {
        public Handaxe()
        {
            Name = "Handaxe";
			Dice = new Dice(6);
            Range = 1;
            Enchanment = 0;
            DamageType = "Slash";
            WeaponType = WeaponTypeEnum.Axe;
        }
    }
}
