using Items.Enums;

namespace Items.Interfaces
{
    public interface IArmor : IItems
    {
        ArmorTypes ArmorType { get; }
        string Name { get; }
        int ArmorValue { get; }
    }
}