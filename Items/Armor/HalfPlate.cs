using Items.Enums;

namespace GameEquipment
{
    public class HalfPlate : Armor
    {
        public HalfPlate()
        {
            base.Name = "Half Plate";
            base.ArmorType = ArmorTypes.Heavy;
            base.ArmorValue = 8;
        }
    }
}
