using Dices;

namespace Items
{
    public class LongSword : Weapon
    {
        public LongSword()
        {
            base.Name = "Longsword";
            base.Dice = new DiceManager(new D8(1));
            base.Range = 1;
            base.Enchanment = 0;
        }
    }
}
