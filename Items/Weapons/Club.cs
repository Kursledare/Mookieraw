using Dices;

namespace Items.Weapons
{
    class Club : Weapon
    {
        public Club()
        {
            Name = "Club";
			Dice = new Dice(6);
            Range = 1;
            Enchanment = 0;
            DamageType = "Blunt";
            WeaponType = WeaponTypeEnum.Mace;
        }
    }
}
