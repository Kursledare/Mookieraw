using Dices;

namespace Items
{
    public class Dagger : Weapon
    {
        public Dagger()
        {
            Name = "Dagger";
            Dice = new Dice(4);
            Enchanment = 0;
            Range = 1;
            CanOneHanded = true;
            DamageType = "Stab";
            WeaponType = WeaponTypeEnum.LightBlade;
        }
    }
}
