namespace IGameObject.Interfaces
{
    interface IPlayerCharacter : ICharacter
    {
        Class Class { get; set; }
        Race Race { get; set; }
        Equipment Equipment { get; set; }
        Inventory Inventory { get; set; }
    }
}
