using System;

namespace Dices
{
    public class Dice
    {
        private readonly Random _r1 = new Random();
        public string Name { get; set; }
        public int Sides { get; set; }
        public int NumofDice { get; set; }
        public Dice(int sides, int numofdice=1)
        {
            Sides = sides;
            NumofDice = numofdice;
        }

        public int Roll()
        {
            int resultat = 0;
            for (int i = 0; i < NumofDice; i++)
            {
                resultat += _r1.Next(1, (Sides + 1));
            }
            return resultat;
        }
    }
}


    //public class D3 : MasterDie
    //{
    //    public D3()
    //    {
    //        base.Name = Die.D3;
    //        base.Sides = 3;
    //        base.NumDice = 1;
    //    }
    //    public D3(int num) :base (num)
    //    {
    //        base.Name = Die.D3;
    //        base.Sides = 3;
    //        base.NumDice = num > 0 ? num : 1;
    //    }
    //}

    //public class D4 : MasterDie
    //{
    //    public D4()
    //    {
    //        base.Name = Die.D4;
    //        base.Sides = 4;
    //        base.NumDice = 1;
    //    }
    //    public D4(int num) :base (num)
    //    {
    //        base.Name = Die.D4;
    //        base.Sides = 4;
    //        base.NumDice = num > 0 ? num : 1;
    //    }
    //}

    //public class D6 : MasterDie
    //{
    //    public D6()
    //    {
    //        base.Name = Die.D6;
    //        base.Sides = 6;
    //        base.NumDice = 1;
    //    }
    //    public D6(int num) :base (num)
    //    {
    //        base.Name = Die.D6;
    //        base.Sides = 6;
    //        base.NumDice = num > 0 ? num : 1;
    //    }
    //}

    //public class D8 : MasterDie
    //{
    //    public D8()
    //    {
    //        base.Name = Die.D8;
    //        base.Sides = 8;
    //        base.NumDice = 1;
    //    }
    //    public D8(int num) :base (num)
    //    {
    //        base.Name = Die.D8;
    //        base.Sides = 8;
    //        base.NumDice = num > 0 ? num : 1;
    //    }

    //}

    //public class D10 : MasterDie
    //{
    //    public D10()
    //    {
    //        base.Name = Die.D10;
    //        base.Sides = 10;
    //        base.NumDice = 1;
    //    }
    //    public D10(int num) :base (num)
    //    {
    //        base.Name = Die.D10;
    //        base.Sides = 10;
    //        base.NumDice = num > 0 ? num : 1;
    //    }
    //}

    //public class D12 : MasterDie
    //{
    //    public D12()
    //    {
    //        base.Name = Die.D12;
    //        base.Sides = 12;
    //        base.NumDice = 1;
    //    }
    //    public D12(int num) :base (num)
    //    {
    //        base.Name = Die.D12;
    //        base.Sides = 12;
    //        base.NumDice = num > 0 ? num : 1;
    //    }

    //}

    //public class D20 : MasterDie
    //{
    //    public D20()
    //    {
    //        base.Name = Die.D20;
    //        base.Sides = 20;
    //        base.NumDice = 1;
    //    }
    //    public D20(int num) :base (num)
    //    {
    //        base.Name = Die.D20;
    //        base.Sides = 20;
    //        base.NumDice = num > 0 ? num : 1;
    //    }
    //}

    //public class D100 : MasterDie
    //{
    //    public D100()
    //    {
    //        base.Name = Die.D100;
    //        base.Sides = 100;
    //        base.NumDice = 1;
    //    }
    //    public D100(int num) :base (num)
    //    {
    //        base.Name = Die.D100;
    //        base.Sides = 100;
    //        base.NumDice = num > 0 ? num : 1;
    //    }
    //}
//}