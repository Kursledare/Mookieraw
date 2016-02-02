using System.Linq;
using Dices;
using EntityData.Interfaces;

namespace EntityData.Classes
{
    public abstract class Class : IClass
    {
        #region Fields
        /// <summary>
        /// The amount of health gained per level is based on the class.
        /// That data is stored here.
        /// </summary>
        public readonly Dice _hitDie; 
        #endregion

        #region Aggregate Totals
        public int ClassLevel { get; set; }

        /// <summary>
        /// This will be replaced/altered in the near future.
        /// </summary>
        public int ClassAttackBonus
        {
            get { return GetClassAttackBonus(ClassLevel, ClassAttackGrowth).First(); }
            set { }
        }

        /// <summary>
        /// This returns the full attack bonus.  It contains the bonuses for
        /// a 'full attack', which can be multiple attacks.
        /// </summary>
        public int[] ClassAttackBonusFull => GetClassAttackBonus(ClassLevel, ClassAttackGrowth);

        /// <summary>
        /// The class adds bonuses to your saves.  These bonuses are calculated by the properties
        /// below.
        /// </summary>
        public int ClassFortBonus => GetClassSaveBonus(ClassLevel, ClassFortGrowth);
        public int ClassReflexBonus => GetClassSaveBonus(ClassLevel, ClassReflexGrowth);
        public int ClassWillBonus => GetClassSaveBonus(ClassLevel, ClassWillGrowth);
        #endregion

        #region Growth Rates
        /// <summary>
        /// Classes have set growth rates for both attack bonuses and saves.  These properties
        /// hold the growth rates for the specific class.
        /// </summary>
        private BaseAttackBonusGrowthRates ClassAttackGrowth { get; set; }

        private SaveGrowthRates ClassFortGrowth { get; set; }
        private SaveGrowthRates ClassReflexGrowth { get; set; }
        private SaveGrowthRates ClassWillGrowth { get; set; }
        #endregion

        #region Growth Rate: Methods
        /// <summary>
        /// Returns the proper ClassAttackBonus based on class level and growth rate.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="growthRate"></param>
        /// <returns></returns>
        private int[] GetClassAttackBonus(int level, BaseAttackBonusGrowthRates growthRate)
        {
            switch (growthRate)
            {
                case BaseAttackBonusGrowthRates.Full:
                    return (int[])BaseAttackBonusGrowthRate.Full.GetValue(ClassLevel);
                case BaseAttackBonusGrowthRates.Moderate:
                    return (int[])BaseAttackBonusGrowthRate.Moderate.GetValue(ClassLevel);
                case BaseAttackBonusGrowthRates.Half:
                    return (int[])BaseAttackBonusGrowthRate.Half.GetValue(ClassLevel);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Returns the proper ClassSaveBonus based on class level and growth rate.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="save"></param>
        /// <returns></returns>
        private int GetClassSaveBonus(int level, SaveGrowthRates save)
        {
            return save == SaveGrowthRates.Half ? SaveGrowthRate.Half[ClassLevel] : SaveGrowthRate.Full[ClassLevel];
        } 
        #endregion
    }

    #region Growth Rate: Static Data
    /// <summary>
    /// These are the different growth rates for the saves that classes have.  They usually follow this pattern.
    /// </summary>
    public static class SaveGrowthRate
    {
        public static readonly int[] Half = { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };
        public static readonly int[] Full = { 0, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
    }

    /// <summary>
    /// These are the different growth rates for attacks that classes have.  They usually follow this pattern.
    /// </summary>
    public static class BaseAttackBonusGrowthRate
    {
        public static readonly int[,] Full = { { 0, 0, 0, 0 }, { 1, 0, 0, 0 }, { 2, 0, 0, 0 }, { 3, 0, 0, 0 }, { 4, 0, 0, 0 }, { 5, 0, 0, 0 }, { 6, 1, 0, 0 }, { 7, 2, 0, 0 }, { 8, 3, 0, 0 }, { 9, 4, 0, 0 }, { 10, 5, 0, 0 }, { 11, 6, 1, 0 }, { 12, 7, 2, 0 }, { 13, 8, 3, 0 }, { 14, 9, 4, 0 }, { 15, 10, 5, 0 }, { 16, 11, 6, 1 }, { 17, 12, 7, 2 }, { 18, 13, 8, 3 }, { 19, 14, 9, 4 }, { 20, 15, 10, 5 } };
        public static readonly int[,] Moderate = { { 0, 0, 0 }, { 0, 0, 0 }, { 1, 0, 0 }, { 2, 0, 0 }, { 3, 0, 0 }, { 3, 0, 0 }, { 4, 0, 0 }, { 5, 0, 0 }, { 6, 1, 0 }, { 6, 1, 0 }, { 7, 2, 0 }, { 8, 3, 0 }, { 9, 4, 0 }, { 9, 4, 0 }, { 10, 5, 0 }, { 11, 6, 1 }, { 12, 7, 2 }, { 12, 7, 2 }, { 13, 8, 3 }, { 14, 9, 4 }, { 15, 10, 5 } };
        public static readonly int[,] Half = { { 0, 0 }, { 0, 0 }, { 1, 0 }, { 1, 0 }, { 2, 0 }, { 2, 0 }, { 3, 0 }, { 3, 0 }, { 4, 0 }, { 4, 0 }, { 5, 0 }, { 5, 0 }, { 6, 1 }, { 6, 1 }, { 7, 2 }, { 7, 2 }, { 8, 3 }, { 8, 3 }, { 9, 4 }, { 9, 4 }, { 10, 5 } };
    }
    #endregion

    #region Growth Rate: Enums
    public enum SaveGrowthRates
    {
        Half, Full
    }

    public enum BaseAttackBonusGrowthRates
    {
        Half, Moderate, Full
    } 
    #endregion
}
