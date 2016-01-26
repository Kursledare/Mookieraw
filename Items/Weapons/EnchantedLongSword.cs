using Dices;

namespace Items
{
    public class EnchantedLongSword : Weapon
    {
        public EnchantedLongSword()
        {
            Name = "Long Sword of Mighty Swing";
            Dice = new Dice(8);
            Enchanment = 1;
        }
    }
}
