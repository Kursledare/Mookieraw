using Items.Enums;

namespace Items.Interfaces
{
    public interface IArmor : IItems
    {
        ArmorTypes ArmorType { get; }
        int ArmorValue { get; }
    }
}