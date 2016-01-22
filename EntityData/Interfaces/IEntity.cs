using CommandHandler.interfaces;
using TurnManager.interfaces;

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
    }
}
