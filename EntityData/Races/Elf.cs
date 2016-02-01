namespace EntityData.Races
{
    public class Elf : Race
    {
        public Elf()
        {
            Size = Size.Medium;
            Type = Type.Humanoid;
            Subrace = SubRace.Elf;
            BaseSpeed = new BaseSpeed(30);
        }
    }
}
