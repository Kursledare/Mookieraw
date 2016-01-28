using Dices;

namespace Items
{
    public class MorningStar : Weapon
    {
        public MorningStar()
        {
            Name = "MorningStar";
            Dice = new Dice(10);
            Enchanment = 0;
            Range = 1;
            CanOneHanded = true;
        }
    }
}
