using Items.Enums;

namespace Items.Armor
{
    class Cloth : GameEquipment.Armor
    {
        public Cloth()
        {
            Name = "Cloth Armor";
            ArmorType = ArmorTypes.Light;
            ArmorValue = 1;
        }
    }
}
