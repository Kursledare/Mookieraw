namespace EntityData.Races
{
    public class Halfling : Race
    {
        public Halfling()
        {
            Size = Size.Small;
            Type = Type.Humanoid;
            Subrace = SubRace.Halfling;
            BaseSpeed=new BaseSpeed(20);
        }
    }
}
