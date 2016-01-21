namespace IGameObject.Interfaces
{
    interface ICharacter : IEntity
    {
        int InitiativeBonus { get; set; }
        Attributes Attributes { get; set; }
        int AttackBonus { get; set; }
        int DamageBonus { get; set; }
    }
}
