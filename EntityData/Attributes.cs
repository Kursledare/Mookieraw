namespace EntityData
{
    public class Attributes
    {
        /// <summary>
        /// This seems way more complicated than it is, more than likely, so I'll break it down.
        /// There are three things in here, Base Attributes, Attribute Bonuses, and Modifiers.
        /// 
        /// Base Attributes are your character's natural attributes.  They are mostly static.
        /// 
        /// Attribute bonuses come from items, weapons, and even spells.  They are kept separate
        /// because they are largely not static.
        /// 
        /// Modifiers are the bonuses that are generated from your attributes.  Basically, an
        /// attribute score of 10 gives you a modifier of 0.  A score of 12 gives you a +1, 14
        /// gives you a +2, and so on.  Below 10 and you get negative scores.
        /// </summary>

        #region Base Attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        #endregion

        #region Race/Level Up Adjustments
        public int[] RaceAdjustments { get; set; }
        public int[] LevelUpAdjustments { get; set; }
        #endregion

        /// <summary>
        /// Not to be confused with the Modifiers, these are simply temporary bonuses
        /// that are applied via equipment, spells, abilities, or conditions.
        /// </summary>
        #region Attribute Bonuses
        public int StrBonus { get; set; }
        public int DexBonus { get; set; }
        public int ConBonus { get; set; }
        public int IntBonus { get; set; }
        public int WisBonus { get; set; }
        public int ChaBonus { get; set; }
        #endregion

        /// <summary>
        /// These are the final product of all the bonuses and things related to your
        /// stats.
        /// </summary>
        #region Modifiers: Aggregate Totals
        public int StrModifier => GetModifier(AttributeTypes.Str);
        public int DexModifier => GetModifier(AttributeTypes.Dex);
        public int ConModifier => GetModifier(AttributeTypes.Con);
        public int IntModifier => GetModifier(AttributeTypes.Int);
        public int WisModifier => GetModifier(AttributeTypes.Wis);
        public int ChaModifier => GetModifier(AttributeTypes.Cha);
        #endregion

        public int GetModifier(AttributeTypes attribute)
        {
            switch (attribute)
            {
                case AttributeTypes.Str:
                    return (Strength + StrBonus - 10)/2;
                case AttributeTypes.Dex:
                    return (Dexterity + DexBonus - 10)/2;
                case AttributeTypes.Con:
                    return (Constitution + ConBonus - 10)/2;
                case AttributeTypes.Int:
                    return (Intelligence + IntBonus - 10)/2;
                case AttributeTypes.Wis:
                    return (Wisdom + WisBonus - 10)/2;
                case AttributeTypes.Cha:
                    return (Charisma + ChaBonus - 10)/2;
                default:
                    return 0;
            }
        }

        public Attributes(int str, int dex, int con, int intelligence, int wis, int cha)
        {
            Strength = str;
            Dexterity = dex;
            Constitution = con;
            Intelligence = intelligence;
            Wisdom = wis;
            Charisma = cha;
        }
    }

    public enum AttributeTypes
    {
        Str, Dex, Con, Int, Wis, Cha
    }
}
