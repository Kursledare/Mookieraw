using Items.Enums;

namespace GameEquipment
{
    public class Chainmail : Armor
    {
        public Chainmail()
        {
            Name = "Chainmail";
            ArmorType = ArmorTypes.Medium;
            ArmorValue = 6;
        }
    }
}
