using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dices;

namespace Items.Weapons
{
    class Club : Weapon
    {
        public Club()
        {
            base.Name = "Club";
			base.Dice = new DiceManager(new D6());
            base.Range = 1;
            base.Enchanment = 0;
        }
    }
}
