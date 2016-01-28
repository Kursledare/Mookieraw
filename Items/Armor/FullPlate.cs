using Items.Enums;

namespace GameEquipment
{
    public class FullPlate : Armor
    {
        public FullPlate()
        {
            Name = "Full Plate";
            ArmorType = ArmorTypes.Heavy;
            ArmorValue = 9;
        }
    }
}
