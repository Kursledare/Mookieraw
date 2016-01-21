namespace Dices
{
    public class D3 : MasterDie
    {
        public D3()
        {
            base.Name = Die.D3;
            base.Sides = 3;
        }
    }

    public class D4 : MasterDie
    {
        public D4()
        {
            base.Name = Die.D4;
            base.Sides = 4;
        }
    }

    public class D6 : MasterDie
    {
        public D6()
        {
            base.Name = Die.D6;
            base.Sides = 6;
        }
    }

    public class D8 : MasterDie
    {
        public D8()
        {
            base.Name = Die.D8;
            base.Sides = 8;
        }
    }

    public class D10 : MasterDie
    {
        public D10()
        {
            base.Name = Die.D10;
            base.Sides = 10;
        }
    }

    public class D12 : MasterDie
    {
        public D12()
        {
            base.Name = Die.D12;
            base.Sides = 12;
        }
    }

    public class D20 : MasterDie
    {
        public D20()
        {
            base.Name = Die.D20;
            base.Sides = 20;
        }
    }

    public class D100 : MasterDie
    {
        public D100()
        {
            base.Name = Die.D100;
            base.Sides = 100;
        }
    }
}