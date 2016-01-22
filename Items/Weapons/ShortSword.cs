using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dices;

namespace Items.Weapons
{
    public class ShortSword : Weapon
    {
        public ShortSword()
        {
            base.Name = "Short Sword";
            base.Dice = new DiceManager(new D4());
            base.Enchanment = 0;
        }
    }
}
