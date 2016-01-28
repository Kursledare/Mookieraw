using Dices;

namespace Items.Weapons
{
    class Flail : Weapon
    {
        public Flail()
        {
            Name = "Flail";
			Dice = new Dice(10);
            Range = 1;
            Enchanment = 0;
            WeaponType = WeaponTypeEnum.Flail;
        }
    }
}
