using Dices;
using EntityData.Monsters;
using GameEquipment;
using Items;
using Items.Shields;

namespace EntityData.MonsterAbilities.Monsters
{
    public class Gnoll : Monster
    {
        public Gnoll()
        {
            Name = "BeepBoop";
            Size = Size.Medium;
            Basespeed.Feet = 30;
            Ac = 15;
            TotalHp = new Dice(8, 2).Roll(2);
            CurrentHp = TotalHp;
            FortSave = 4;
            ReflexSave = 0;
            WillSave = 0;
            Equipment.Weapons.Add(new Spear());
            Equipment.Armor.Add(new LeatherArmor());
            Equipment.Shield = new WoodenShield();
            Attributes = new Attributes(15, 10, 13, 8, 11, 8);
            AttackBonus = 1;
        }
    }
}