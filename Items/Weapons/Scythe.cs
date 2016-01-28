using Dices;

namespace Items.Weapons
{
    class Scythe: Weapon
    {
        public Scythe()
        {
            Name = "Scythe";
			Dice = new Dice(4,2);
            Range = 1;
            Enchanment = 0;
        }
    }
}
