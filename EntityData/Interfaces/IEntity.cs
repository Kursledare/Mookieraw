using TurnManager.interfaces;

namespace EntityData.Interfaces
{
    public interface IEntity:IGameObject
    {
        int CurrentHp { get; set; }
        int Ac { get; set; }
        int FortSave { get; set; }
        int ReflexSave { get; set; }
        int WillSave { get; set; }
    }
}
