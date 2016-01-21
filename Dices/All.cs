using System;

namespace Dices
{
    public interface IDice
    {
        //Int32 Roll()
        //{
        //    Random rand1 = new Random();

        //    int sum = rand1.Next(1, 7);
        //    int count = 1;

        //    {
        //        sum = rand1.Next(1, 7);
        //        count++;
        //    }

        //    return count;
        //}

        Int32 Sides
        {
            get;
            set;
        }

        String Name
        {
            get;
            set;
        }
        
    }

    public class Dice
    {
        public class D3 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D3"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 3; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
        public class D4 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D4"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 4; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
        public class D8 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D8"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 8; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
        public class D10 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D10"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 10; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
        public class D12 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D12"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 12; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
        public class D20 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D20"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 20; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
        public class D100 : IDice
        {
            public string Name
            {
                get { return Name; }
                set { Name = "D100"; }
            }

            public int Sides
            {
                get { return Sides; }
                set { Sides = 100; }
            }

            public int Roll()
            {
                throw new NotImplementedException();
            }
        }
    }

}
