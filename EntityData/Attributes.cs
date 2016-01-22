namespace EntityData
{
    public class Attributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

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
}
