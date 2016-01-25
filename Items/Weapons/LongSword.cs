using Dices;

namespace Items
{
    public class LongSword : Weapon
    {
        public LongSword()
        {
            base.Name = "Longsword";
            base.Dice = new Dice(8);
            base.Range = 1;
            base.Enchanment = 0;
        }
    }
}
