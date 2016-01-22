using System;
using Dices.Interfaces;

namespace Dices
{
    /// <summary>
    /// This is the abstract class from which all other dice inherit from.
    /// 
    /// In later versions, I'm thinking it might be cool to have properties
    /// attached to dice.  Such as fire, acid, electric, sonic, etc.  This
    /// would be a nifty way to handle elemental damage.
    /// </summary>
    public abstract class MasterDie : IDice
    {
        private readonly Random _rand;

        public int Sides { get; protected set; }
        public Die Name { get; protected set; }

        /// <summary>
        /// Rolls the specific die.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            var resultat = _rand.Next(1, (Sides + 1));
            return resultat;
        }

        /// <summary>
        /// Overloaded method that accepts an integer as bonus damage.
        /// </summary>
        /// <param name="bonus"></param>
        /// <returns></returns>
        public int Roll(int bonus)
        {
            var resultat = _rand.Next(1, (Sides + 1));
            return resultat + bonus;
        }

        protected MasterDie()
        {
            _rand = new Random();
        }
    }
}
