using Dices;
using EntityData.Characters;
using GameEquipment;
using Items.Shields;
using Items.Weapons;

namespace EntityData.Monsters
{
    public class Goblin : Character
    {
        public Goblin() : base()
        {
            base.Name = "Gerblin";
            base.Ac = 16;
            base.TotalHp = new Dice(10).Roll();
            base.CurrentHp = TotalHp;
            base.FortSave = 3;
            base.ReflexSave = 2;
            base.WillSave = -1;
            base.Equipment.Weapons.Add(new ShortSword());
            base.Equipment.Armor.Add(new LeatherArmor());
            base.Equipment.Shield=new WoodenShield();
            base.Attributes = new Attributes(11,15,12,10,9,6);
            base.AttackBonus = 1;
        }
    }
}
