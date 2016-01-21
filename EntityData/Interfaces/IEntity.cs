using CommandHandler.interfaces;
using TurnManager.interfaces;

namespace EntityData.Interfaces
{
    public interface IEntity:IGameObject,ICommandable
    {
        int CurrentHp { get; set; }
        int Ac { get; set; }
        int FortSave { get; set; }
        int ReflexSave { get; set; }
        int WillSave { get; set; }
    }
}
