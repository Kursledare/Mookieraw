namespace EntityData.Interfaces
{
    interface IPlayerCharacter : ICharacter
    {
        IClass Class { get; set; }
        IRace Race { get; set; }
        Inventory Inventory { get; set; }
    }
}
