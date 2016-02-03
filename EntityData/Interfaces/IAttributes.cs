namespace EntityData.Interfaces
{
    public interface IAttributes
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
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Constitution { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Charisma { get; set; }

        /// <summary>
        /// Not to be confused with the Modifiers, these are simply temporary bonuses
        /// that are applied via equipment, spells, abilities, or conditions.
        /// </summary>
        #region Temp Attribute Bonuses
        int TempStrBonus { get; set; }
        int TempDexBonus { get; set; }
        int TempConBonus { get; set; }
        int TempIntBonus { get; set; }
        int TempWisBonus { get; set; }
        int TempChaBonus { get; set; }
        #endregion

        /// <summary>
        /// These are the final product of all the bonuses and things related to your
        /// stats.
        /// </summary>
        #region Modifiers: Aggregate Totals
        int StrModifier { get; }
        int DexModifier { get; }
        int ConModifier { get; }
        int IntModifier { get; }
        int WisModifier { get; }
        int ChaModifier { get; }
        #endregion

        int GetModifier(AttributeTypes attribute);
    }
}