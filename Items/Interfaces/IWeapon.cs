using Dices;

namespace Items.Interfaces
{
    public interface IWeapon : IItems
    {
        int Enchanment { get; set; }

        DiceManager Dice { get; }

        int DamageRoll();
        bool CanOneHanded { get; set; }
    }
}