using Dices;
using Items.Interfaces;

namespace Items
{
    public abstract class Weapon : IWeapon
    {
        public int Enchanment { get; set; }

        public DiceManager Dice { get; protected set; }

        public int DamageRoll()
        {
            return Dice.RollAll();
        }

        public bool CanOneHanded { get; set; }

        public string Name { get; protected set; }
    }
}
