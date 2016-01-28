using Items.Enums;

namespace Items.Shields
{
    public class WoodenShield : Shield
    {
        public WoodenShield()
        {
            Name = "Wooden Shield";
            ArmorType = ArmorTypes.Light;
            ArmorValue = 1;
        }
    }
}
