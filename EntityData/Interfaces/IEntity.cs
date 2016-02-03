using System.Dynamic;
using System.Reflection;
using CommandHandler.interfaces;
using GameEngine.interfaces;

namespace EntityData.Interfaces
{
    public interface IEntity:IGameObject,ICommandable
    {
        string Name { get; set; }
        int Level { get; set; }
        Class Class { get; set; }
        Race Race { get; set; }
        int MaxHp { get; set; }
        int CurrentHp { get; set; }
        int Speed { get; set; }
        Size Size { get; set; }
        int InitiativeBonus { get; }
        IAttributes Attributes { get; set; }
        IOffence Offence { get; set; }
        IDefence Defence { get; set; }
        IEquipment Equipment { get; set; }
        void AlterHealth(int amount);
    }

    public enum Class
    {
        Fighter, Wizard
    }

    public enum Race
    {
        Human, Goblin
    }

    public enum Size
    {
        Fine, Diminutive, Tiny, Small, Medium, LargeTall, LargeLong, HugeTall, HugeLong, GargantuanTall, GargantuanLong, ColossalTall, ColossalLong
    }
}
