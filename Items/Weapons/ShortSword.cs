using Dices;

namespace Items.Weapons
{
    public class ShortSword : Weapon
    {
        public ShortSword()
        {
            Name = "Short Sword";
            Dice = new Dice(4);
            Range = 1;
            Enchanment = 0;
            DamageType = "Slash";
            WeaponType = WeaponTypeEnum.LightBlade;
        }
    }
}
