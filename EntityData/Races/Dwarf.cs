namespace EntityData.Races
{
    public class Dwarf : Race
    {
        public Dwarf()
        {
            Size = Size.Medium;
            Type = Type.Humanoid;
            Subrace = SubRace.Dwarf;
            BaseSpeed = new BaseSpeed(20);
        }
    }
}
