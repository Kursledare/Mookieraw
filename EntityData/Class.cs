using System.CodeDom;
using System.Security.Permissions;
using EntityData.Interfaces;

namespace EntityData
{
    public class Class : IClass
    {
        public int ClassLevel { get; set; }

        public int ClassAttackBonus
        {
            get
            {
                //if(ClassAttackGrowth = BaseAttackBonusGrowthRates.Half)
                //    return SaveGrowthRate
                return 1;
            }
            set { }
        }

        public int ClassFortBonus { get; set; }
        public int ClassReflexBonus { get; set; }
        public int ClassWillBonus { get; set; } 

        public BaseAttackBonusGrowthRates ClassAttackGrowth { get; set; }

        public SaveGrowthRates ClassFortGrowth { get; private set; }
        public SaveGrowthRates ClassReflexGrowth { get; private set; }
        public SaveGrowthRates ClassWillGrowth { get; private set; }

        //public int[] GetNumberFromGrowthRate(int level, BaseAttackBonusGrowthRates growthRate)
        //{
        //    switch (growthRate)
        //    {
        //        case BaseAttackBonusGrowthRates.Full:
        //            return BaseAttackBonusGrowthRate.Full.GetValue(new int[ClassLevel,ClassLevel,ClassLevel,ClassLevel]);
        //    }
        //}

    }

    /// <summary>
    /// These are the different growth rates for the saves that classes have.  They usually follow this pattern.
    /// </summary>
    public static class SaveGrowthRate
    {
        public static readonly int[] Half = {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6};
        public static readonly int[] Full = {0, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12};
    }

    /// <summary>
    /// These are the different growth rates for attacks that classes have.  They usually follow this pattern.
    /// </summary>
    public static class BaseAttackBonusGrowthRate
    {
        public static readonly int[,] Full = { {0,0,0,0}, {1,0,0,0}, {2,0,0,0}, {3,0,0,0}, {4,0,0,0}, {5,0,0,0}, {6,1,0,0}, {7,2,0,0}, {8,3,0,0}, {9,4,0,0}, {10,5,0,0}, {11,6,1,0}, {12,7,2,0}, {13,8,3,0}, {14,9,4,0}, {15,10,5,0}, {16,11,6,1}, {17,12,7,2}, {18,13,8,3}, {19,14,9,4}, {20,15,10,5}};
        public static readonly int[,] Moderate = { {0,0,0}, {0,0,0}, {1,0,0}, {2,0,0}, {3,0,0}, {3,0,0}, {4,0,0}, {5,0,0}, {6,1,0}, {6,1,0}, {7,2,0}, {8,3,0}, {9,4,0}, {9,4,0}, {10,5,0}, {11,6,1}, {12,7,2}, {12,7,2}, {13,8,3}, {14,9,4}, {15,10,5}};
        public static readonly int[,] Half = { {0,0}, {0,0}, {1,0}, {1,0}, {2,0}, {2,0}, {3,0}, {3,0}, {4,0}, {4,0}, {5,0}, {5,0}, {6,1}, {6,1}, {7,2}, {7,2}, {8,3}, {8,3}, {9,4}, {9,4}, {10,5}};
    }

    public enum SaveGrowthRates
    {
        Half, Full
    }

    public enum BaseAttackBonusGrowthRates
    {
        Half, Moderate, Full
    }
}
