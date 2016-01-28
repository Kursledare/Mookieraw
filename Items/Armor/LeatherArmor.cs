using Items.Enums;

namespace GameEquipment
{
   public class LeatherArmor : Armor
   {
       public LeatherArmor()
       {
            Name = "Leather Armor";
            ArmorType = ArmorTypes.Light;
            ArmorValue = 2;
       }
    }
}
