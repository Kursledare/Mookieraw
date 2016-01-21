using Items.Interfaces;
using System;
using GameEquipment;

namespace Items
{
    public class LongSword : IWeapon
    {
        public int Enchanment
        {
            
            get
            {
                return Enchanment;
            }

            set
            {
                Enchanment = value;
            }
        }

        public int NumOfDice { get; set; }

        public string Name { get; set; }

        public string DiceSize { get; }

        public int DamageRoll()
        {
            throw new NotImplementedException();
        }
    }
}
