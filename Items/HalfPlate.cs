using Items.Enums;
using Items.Interfaces;

namespace GameEquipment
{
    class HalfPlate : Armor
    {
        public HalfPlate()
        {
            base.Name = "Half Plate";
            base.ArmorType = ArmorTypes.Heavy;
            base.ArmorValue = 8;
        }
    }
}
