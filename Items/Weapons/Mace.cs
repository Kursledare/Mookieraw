using Dices;

namespace Items
{
    public class Mace : Weapon
    {
        public Mace()
        {
            Name = "Mace";
            Dice = new Dice(8);
            Enchanment = 0;
            Range = 1;
            CanOneHanded = true;
            DamageType = "Blunt";
            WeaponType = WeaponTypeEnum.Mace;
        }
    }
}
