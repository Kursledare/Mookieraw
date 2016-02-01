namespace EntityData.Races
{
    public class Human : Race
    {
        public Human()
        {
            Size = Size.Medium;
            Type = Type.Humanoid;
            Subrace = SubRace.Human;
            BaseSpeed=new BaseSpeed(30);
        }
    }
}
