using Dices;

namespace Items
{
    public class Spear : Weapon
    {
        public Spear()
        {
            Name = "Spear";
            Dice = new Dice(8);
            Enchanment = 0;
            Range = 2;
            CanOneHanded = true;
        }
    }
}
