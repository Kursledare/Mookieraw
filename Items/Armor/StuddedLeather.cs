using Items.Enums;

namespace GameEquipment
{
    class StuddedLeather : Armor
    {
        public StuddedLeather()
        {
            base.Name = "Studded Leather";
            base.ArmorType = ArmorTypes.Light;
            base.ArmorValue = 3;
        }
    }
}