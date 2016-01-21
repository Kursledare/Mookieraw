namespace Items.Interfaces
{
    public interface IWeapon : IItems
    {
        int Enchanment { get; set; }

        int NumOfDice { get; set; }

        string DiceSize { get; }

        int DamageRoll();
    }
}