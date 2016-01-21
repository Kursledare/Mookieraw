using Dices;

namespace Items
{
    public class LongSword : Weapon
    {
        public LongSword()
        {
            base.Name = "Longsword";
            base.Dice = new DiceManager(new D8());
            base.Enchanment = 0;
        }
    }
}
