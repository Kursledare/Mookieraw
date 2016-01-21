namespace ProjecktMookieraaw_Weapon
{
    public interface IWeapon
    {
        int Enchanment { get; set; }

        int NumOfDise { get; set; }

        string DiceZise { get; }

        int DamageRoll();
    }
}