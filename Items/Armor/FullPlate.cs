using Items.Enums;

namespace GameEquipment
{
    public class FullPlate : Armor
    {
        public FullPlate()
        {
            base.Name = "Full Plate";
            base.ArmorType = ArmorTypes.Heavy;
            base.ArmorValue = 9;
        }
    }
}
