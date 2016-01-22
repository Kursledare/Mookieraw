using Items.Enums;

namespace GameEquipment
{
    public class Chainmail : Armor
    {
        public Chainmail()
        {
            base.Name = "Chainmail";
            base.ArmorType = ArmorTypes.Medium;
            base.ArmorValue = 6;
        }
    }
}
