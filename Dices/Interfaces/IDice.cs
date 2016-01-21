using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dices.Interfaces
{
    public interface IDice
    {
        Int32 Sides
        {
            get;
            set;
        }
        String Name
        {
            get;
            set;
        }
        Int32 Roll(Dice dice);
    }
}
