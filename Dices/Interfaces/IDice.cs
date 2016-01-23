using System;

namespace Dices.Interfaces
{
    public interface IDice
    {
        Int32 NumDice { get; }
        Int32 Sides
        {
            get;
        }
        Die Name
        {
            get;
        }
        Int32 Roll();
    }
}
