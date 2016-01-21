using System;
using Dices.Interfaces;

namespace Dices
{
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

        protected MasterDie()
        {
            _rand = new Random();
        }
    }
}
