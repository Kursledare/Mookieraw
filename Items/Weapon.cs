using System;
using Items.Interfaces;

namespace Items
{
    public abstract class Weapon : IWeapon
    {
        public string Name { get; protected set; }
        public int Enchanment { get; set; }
        public int NumOfDice { get; set; }
        public string DiceSize { get; }
        public int DamageRoll()
        {
            throw new NotImplementedException();
        }
    }
}
