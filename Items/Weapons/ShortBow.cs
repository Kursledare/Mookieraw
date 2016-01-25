using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dices;

namespace Items.Weapons
{
    class ShortBow : Weapon
    {
        public ShortBow()
        {
            base.Name = "ShortBow";
			base.Dice = new DiceManager(new D8());
            base.Range = 30;
            base.Enchanment = 0;
        }
    }
}
