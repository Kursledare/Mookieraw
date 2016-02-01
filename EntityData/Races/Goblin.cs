namespace EntityData.Races
{
    public class Goblin : Race
    {
        public Goblin()
        {
            Size = Size.Small;
            Type = Type.Humanoid;
            Subrace = SubRace.Goblin;
            BaseSpeed = new BaseSpeed(20);
        }
    }
}
