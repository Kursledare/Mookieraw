using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dices.Interfaces;

namespace Dices
{
    public class DiceManager
    {
        private ICollection<IDice> _dice;

        public ICollection<IDice> Dice
        {
            get { return _dice; }
            set { _dice = value; }
        }

        /// <summary>
        /// Rolls all the dice held by the manager.  This is a barebones
        /// version that will likely change.
        /// </summary>
        /// <returns></returns>
        public int RollAll()
        {
            return Dice.Sum(dice => dice.Roll());
        }

        public DiceManager(params IDice[] dice)
        {
            Dice = dice;
        }
    }
}
