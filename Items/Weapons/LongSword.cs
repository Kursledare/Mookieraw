using Dices;

namespace Items
{
    public class LongSword : Weapon
    {
        public LongSword()
        {
            Name = "Longsword";
            Dice = new Dice(8);
            Range = 1;
            Enchanment = 0;
        }
    }
}
