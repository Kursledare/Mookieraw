using GameEquipment;
using Items;

namespace EntityData.Characters
{
    public class BasicFighter : Character
    {
        public BasicFighter(string name)
        {
            base.Name = string.IsNullOrEmpty(name) ? "Derp" : name;
            base.FortSave = 4;
            base.ReflexSave = 1;
            base.WillSave = 0;
            base.AttackBonus = 5;
            base.Attributes = new Attributes(18, 12, 14, 8, 10, 10);
            base.TotalHp = new Dices.Dice(10,1).Roll();
            base.CurrentHp = TotalHp;
            base.Equipment.Weapons.Add(new GreatSword());
            base.Equipment.Armor.Add(new Chainmail());
        }
    }
}
