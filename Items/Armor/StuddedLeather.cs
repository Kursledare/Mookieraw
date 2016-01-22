using Items.Enums;

namespace Items.Armor
{
    public class StuddedLeather : GameEquipment.Armor
    {
        public StuddedLeather()
        {
            base.Name = "Studded Leather";
            base.ArmorType = ArmorTypes.Light;
            base.ArmorValue = 3;
        }
    }
}