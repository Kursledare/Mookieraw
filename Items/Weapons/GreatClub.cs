using Dices;

namespace Items.Weapons
{
    class GreatClub : Weapon
    {
        public GreatClub()
        {
            Name = "GreatClub";
			Dice = new Dice(4,2);
            Range = 1;
            Enchanment = 0;
        }
    }
}
