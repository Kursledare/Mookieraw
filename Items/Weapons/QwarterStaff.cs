using Dices;

namespace Items.Weapons
{
    class QwarterStaff : Weapon
    {
        public QwarterStaff()
        {
            Name = "QwarterStaff";
			Dice = new Dice(8);
            Range = 1;
            Enchanment = 0;
        }
    }
}
