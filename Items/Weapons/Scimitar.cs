using Dices;

namespace Items.Weapons
{
    class Scimitar : Weapon
    {
        public Scimitar()
        {
            Name = "Scimitar";
			Dice = new Dice(8);
            Range = 1;
            Enchanment = 0;
            DamageType = "Slash";
            WeaponType = WeaponTypeEnum.LightBlade;
        }
    }
}
