using Dices;

namespace Items.Weapons
{
    class BattleAxe : Weapon
    {
        public BattleAxe()
        {
            Name = "BattleAxe";
			Dice = new Dice(10);
            Range = 1;
            Enchanment = 0;
            DamageType = "Slash";
            WeaponType = WeaponTypeEnum.Axe;
        }

        
    }
}
