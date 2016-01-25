using Dices;

namespace Items
{
    public class GreatSword : Weapon
    {
        public GreatSword()
        {
            base.Name = "GreatSword";
            base.Dice = new Dice(6,2);
            base.Enchanment = 0;
            base.Range = 1;
            base.CanOneHanded = false;
        }
    }
}
