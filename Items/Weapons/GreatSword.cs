using Dices;

namespace Items
{
    public class GreatSword : Weapon
    {
        public GreatSword()
        {
            Name = "GreatSword";
            Dice = new Dice(6,2);
            Enchanment = 0;
            Range = 1;
            CanOneHanded = false;
            DamageType = "Slash";
            WeaponType = WeaponTypeEnum.HeavyBlade;
        }
    }
}
