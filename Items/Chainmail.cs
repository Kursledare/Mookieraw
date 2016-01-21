using Items.Enums;

namespace GameEquipment
{
    class Chainmail : Armor
    {
        public Chainmail()
        {
            base.Name = "Chainmail";
            base.ArmorType = ArmorTypes.Medium;
            base.ArmorValue = 6;
        }
    }
}
