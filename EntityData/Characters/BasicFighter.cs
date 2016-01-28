using System.Security.Cryptography.X509Certificates;
using GameEquipment;
using Items;

namespace EntityData.Characters
{
    public class BasicFighter : Character
    {
        public BasicFighter(string name)
        {
            Name = string.IsNullOrEmpty(name) ? "Derp" : name;
            FortSave = 4;
            ReflexSave = 1;
            WillSave = 0;
            AttackBonus = 5;
            Attributes = new Attributes(18, 12, 14, 8, 10, 10);
            TotalHp = new Dices.Dice(10).Roll();
            CurrentHp = TotalHp;
            Equipment.Weapons.Add(new GreatSword());
            Equipment.Armor.Add(new Chainmail());
            
        }
    }
}
