using EntityData.Races;

namespace EntityData.Interfaces
{
    public interface IRace
    {
        Attributes RaceModifier { get; set; }
        Size Size { get; set; }
        Type Type { get; set; }
        SubRace Subrace { get; set; }
        BaseSpeed BaseSpeed { get; set; }
    }
}
