using Dices;

namespace Items
{
    public class GreatSword : Weapon
    {
        public GreatSword()
        {
            base.Name = "GreatSword";
            base.Dice = new DiceManager( new D8(),new D6());
            base.Enchanment = 0;
        }
    }
}
