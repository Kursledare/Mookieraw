namespace EntityData.Races
{
    public class Gnome : Race
    {
        public Gnome()
        {
            Size = Size.Small;
            Type = Type.Humanoid;
            Subrace = SubRace.Gnome;
            BaseSpeed = new BaseSpeed(30);
        }
    }
}
