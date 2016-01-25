using System;

namespace Dices.Interfaces
{
    public interface IDice
    {
        int NumDice { get; }
        int Sides { get; }
        string Name { get; }
        int Roll();
    }
}
