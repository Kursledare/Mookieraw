using Items.Enums;

namespace Items.Armor
{
    public class StuddedLeather : GameEquipment.Armor
    {
        public StuddedLeather()
        {
            Name = "Studded Leather";
            ArmorType = ArmorTypes.Light;
            ArmorValue = 3;
        }
    }
}