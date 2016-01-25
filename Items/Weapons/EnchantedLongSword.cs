using Dices;

namespace Items
{
    public class EnchantedLongSword : Weapon
    {
        public EnchantedLongSword()
        {
            base.Name = "Long Sword of Mighty Swing";
            base.Dice = new Dice(8);
            base.Enchanment = 1;
        }
    }
}
