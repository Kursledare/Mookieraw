using CommandHandler.interfaces;
using GameEngine.interfaces;

namespace EntityData.Interfaces
{
    public interface IEntity:IGameObject,ICommandable
    {
        string Name { get; set; }
        int TotalHp { get; set; }
        int CurrentHp { get; set; }
        int Ac { get; set; }
        int FortSave { get; set; }
        int ReflexSave { get; set; }
        int WillSave { get; set; }
        void AlterHealth(int amount);
        int InitiativeBonus { get; set; }
        Attributes Attributes { get; set; }
        int AttackBonus { get; set; }
        int DamageBonus { get; set; }
        Equipment Equipment { get; set; }
        Class Class { get; set; }
        Race Race { get; set; }
        Inventory Inventory { get; set; }
    }
}
