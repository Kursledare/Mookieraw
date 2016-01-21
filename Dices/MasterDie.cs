using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dices.Interfaces;

namespace Dices
{
    public abstract class MasterDie : IDice
    {
        private readonly Random _rand;

        public int Sides { get; protected set; }
        public string Name { get; protected set; }

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
