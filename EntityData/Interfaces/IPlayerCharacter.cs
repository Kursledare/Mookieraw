namespace EntityData.Interfaces
{
    interface IPlayerCharacter : ICharacter
    {
        Class Class { get; set; }
        Race Race { get; set; }
        Inventory Inventory { get; set; }
    }
}
