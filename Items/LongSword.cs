
using System;
using GameEquipment;

namespace ProjecktMookieraaw_Weapon
{
    public class LongSword : IWeapon , IItems
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

        public string Name { get; set; }

        public int NumOfDise
        {
            get { return NumOfDise; }
            set { NumOfDise = value; }
        }

        public string DiceZise
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int DamageRoll()
        {
            throw new NotImplementedException();
        }
    }
}
