using Items.Enums;

namespace GameEquipment
{
   public class LeatherArmor : Armor
   {
       public LeatherArmor()
       {
            base.Name = "Leather Armor";
            base.ArmorType = ArmorTypes.Light;
            base.ArmorValue = 2;
       }
    }
}
